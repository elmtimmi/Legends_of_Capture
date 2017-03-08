using UnityEngine;
using System.Collections;
using System;
using TF;

[Serializable]
public class TFJointLimitMotor
{
	[Tooltip("powered joint: velocity, max force")]
	public float vel = 0f, fmax = 0f;
	[Tooltip("joint limits, relative to initial position")]
	public float lostop = float.MinValue, histop = float.MaxValue;
	[Tooltip("when powering away from joint limits")]
	public float fudge_factor = 1f;
	[Tooltip("cfm to use when not at a stop")]
	public float normal_cfm = TFJoint.DEFAULT_CFM;
	[Tooltip("erp and cfm for when at joint limit")]
	public float stop_erp = TFJoint.DEFAULT_ERP, stop_cfm = TFJoint.DEFAULT_CFM;
	[Tooltip("restitution factor")]
	public float bounce = 0f; 
	
	//variables used between getJ.Offset1() and getJ.Offset2()
	[Tooltip("0=free, 1=at lo limit, 2=at hi limit")]
	public int limit;
	[Tooltip("if at limit, amount over limit")]
	public float limit_err;

	internal bool testRotationalLimit(float angle)
	{
		if (angle <= lostop)
		{
			limit = 1;
			limit_err = angle - lostop;
			return true;
		}
		else if (angle >= histop)
		{
			limit = 2;
			limit_err = angle - histop;
			return true;
		}
		else
		{
			limit = 0;
			return false;
		}
	}

	internal bool testLinearLimit(float pos)
	{
		if (pos <= lostop)
		{
			limit = 1;
			limit_err = pos - lostop;
			return true;
		}
		else if (pos >= histop)
		{
			limit = 2;
			limit_err = pos - histop;
			return true;
		}
		else
		{
			limit = 0;
			return false;
		}
	}

	internal int addLimot(TFJoint joint, ArraySegment<TF.TFJoint.Constraint> J, int srow, Vector3 ax1, bool rotational)
	{
		// if the joint is powered, or has joint limits, add in the extra row
		bool powered = fmax > 0f;
		if (powered || (limit != 0))
		{
			if (rotational)
			{
				J.Array[J.Offset + srow].J1a = ax1;

				if (joint.node1.body != null)
				{
					J.Array[J.Offset + srow].J2a = -ax1;
				}
			}
			else
			{
				J.Array[J.Offset + srow].J1l = ax1;

				if (joint.node1.body != null)
				{
					J.Array[J.Offset + srow].J2l = -ax1;
				}
			}

			// linear limot torque decoupling step:
			//
			// if this is a linear limot (e.g. from a slider), we have to be careful
			// that the linear constraint forces (+/- ax1) applied to the two bodies
			// do not create a torque couple. in other words, the points that the
			// constraint force is applied at must lie along the same ax1 axis.
			// a torque couple will result in powered or limited slider-jointed free
			// bodies from gaining angular momentum.
			// the solution used here is to apply the constraint forces at the point
			// halfway between the body centers. there is no penalty (other than an
			// extra tiny bit of computation) in doing this adjustment. note that we
			// only need to do this if the constraint connects two bodies.

			Vector3 ltd;   // Linear Torque Decoupling vector (a torque)
			if (!rotational && (joint.node1.body != null))
			{
				Vector3 c = 0.5f * (joint.node1.body.transform.position - joint.node0.body.transform.position);
				ltd = Vector3.Cross(c, ax1);
				J.Array[J.Offset + srow].J1a = ltd;
				J.Array[J.Offset + srow].J2a = ltd;
			}
			else
			{
				ltd = new Vector3();
			}

			// if we're limited low and high simultaneously, the joint motor is
			// ineffective
			if ((limit != 0) && (lostop == histop)) powered = false;

			if (powered)
			{
				J.Array[J.Offset + srow].cfm = normal_cfm;
				if (limit == 0)
				{
					J.Array[J.Offset + srow].c = vel;
					J.Array[J.Offset + srow].lo = -fmax;
					J.Array[J.Offset + srow].hi = fmax;
				}
				else
				{
					// the joint is at a limit, AND is being powered. if the joint is
					// being powered into the limit then we apply the maximum motor force
					// in that direction, because the motor is working against the
					// immovable limit. if the joint is being powered away from the limit
					// then we have problems because actually we need *two* lcp
					// constraints to handle this case. so we fake it and apply some
					// fraction of the maximum force. the fraction to use can be set as
					// a fudge factor.

					float fm = fmax;
					if (vel > 0f) fm = -fm;

					// if we're powering away from the limit, apply the fudge factor
					if ((limit == 1 && vel > 0f) || (limit == 2 && vel < 0f)) fm *= fudge_factor;

					if (rotational)
					{
						joint.node0.body.AddTorque(-fm * ax1);

						if (joint.node1.body != null)
							joint.node1.body.AddTorque(fm * ax1);
					}
					else
					{
						joint.node0.body.AddForce(-fm * ax1);

						if (joint.node1.body != null)
						{
							joint.node1.body.AddForce(fm * ax1);

							// linear limot torque decoupling step: refer to above discussion
							joint.node0.body.AddTorque(-fm * ltd);
							joint.node1.body.AddTorque(-fm * ltd);
						}
					}
				}
			}

			if (limit != 0)
			{
				float k = TFJoint.Constraint.fps * stop_erp;
				J.Array[J.Offset + srow].c = -k * limit_err;
				J.Array[J.Offset + srow].cfm = stop_cfm;

				if (lostop == histop)
				{
					// limited low and high simultaneously
					J.Array[J.Offset + srow].lo = float.MinValue;
					J.Array[J.Offset + srow].hi = float.MaxValue;
				}
				else
				{
					if (limit == 1)
					{
						// low limit
						J.Array[J.Offset + srow].lo = 0f;
						J.Array[J.Offset + srow].hi = float.MaxValue;
					}
					else
					{
						// high limit
						J.Array[J.Offset + srow].lo = float.MinValue;
						J.Array[J.Offset + srow].hi = 0f;
					}

					// deal with bounce
					if (bounce > 0f)
					{
						// calculate joint velocity
						float vel;
						if (rotational)
						{
							vel = Vector3.Dot(joint.node0.body.velocities.current.angular, ax1);
							if (joint.node1.body != null)
								vel -= Vector3.Dot(joint.node1.body.velocities.current.angular, ax1);
						}
						else
						{
							vel = Vector3.Dot(joint.node0.body.velocities.current.linear, ax1);
							if (joint.node1.body != null)
								vel -= Vector3.Dot(joint.node1.body.velocities.current.linear, ax1);
						}

						// only apply bounce if the velocity is incoming, and if the
						// resulting c[] exceeds what we already have.
						if (limit == 1)
						{
							// low limit
							if (vel < 0f)
							{
								float newc = -bounce * vel;
								if (newc > J.Array[J.Offset + srow].c) J.Array[J.Offset + srow].c = newc;
							}
						}
						else
						{
							// high limit - all those computations are reversed
							if (vel > 0f)
							{
								float newc = -bounce * vel;
								if (newc < J.Array[J.Offset + srow].c) J.Array[J.Offset + srow].c = newc;
							}
						}
					}
				}
			}
			return 1;
		}
		else return 0;
	}
}
