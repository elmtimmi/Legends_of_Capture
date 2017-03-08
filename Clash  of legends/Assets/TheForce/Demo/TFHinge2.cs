using UnityEngine;
using System.Collections;
using TF;
using System;
using UnityEngine.Assertions;

public class TFHinge2 : TFJoint
{
	Vector3 anchor0 = new Vector3();      // anchor w.r.t first body
	Vector3 anchor1 = new Vector3();      // anchor w.r.t second body
	Vector3 axis0 = new Vector3();        // axis 0 w.r.t first body
	Vector3 axis1 = new Vector3();        // axis 1 w.r.t second body
	float c0, s0;           // cos,sin of desired angle between axis 0,1
	Vector3 v0 = new Vector3();
	Vector3 v1 = new Vector3();       // angle ref vectors embedded in first body
	public TFJointLimitMotor limot0 = new TFJointLimitMotor(); // limit+motor info for axis 0
	public TFJointLimitMotor limot1 = new TFJointLimitMotor(); // limit+motor info for axis 1

	[Tooltip("suspension parameters (erp,cfm)")]
	public float susp_erp, susp_cfm, susp_preload;

	public override void getInfo1(ref Info1 info)
	{
		info.m = 4;

		// see if we're powered or at a joint limit for axis 1
		int atlimit = 0;
		if ((limot0.lostop >= -Mathf.PI || limot0.histop <= Mathf.PI) &&
			limot0.lostop <= limot0.histop)
		{
			float angle = MeasureHinge2Angle();
			if (limot0.testRotationalLimit(angle)) atlimit = 1;
		}
		if (atlimit != 0 || limot0.fmax > 0) info.m++;

		// see if we're powering axis 2 (we currently never limit this axis)
		limot1.limit = 0;
		if (limot1.fmax > 0) info.m++;
	}

	public float MeasureHinge2Angle()
	{
		Vector3 a0, a1;
		a0 = node1.body.transform.TransformDirection(axis1);//node1.body.transform.up;
		a1 = node0.body.transform.InverseTransformDirection(a0);
		float x = Vector3.Dot(v0, a1);
		float y = Vector3.Dot(v1, a1);
		return -Mathf.Atan2(y, x);
	}

	internal float GetPosition()
	{
		Vector3 a0, a1;
		Vector3 axis;
		axis = node0.body.transform.TransformDirection(axis0);
		a0 = node0.body.transform.TransformPoint(anchor0);
		a1 = node1.body.transform.TransformPoint(anchor1);
		return -(Vector3.Dot(axis, a1) - Vector3.Dot(axis, a0));
	}

	// macro that computes ax0,ax1 = axis 0 and 1 in global coordinates (they are
	// relative to body 1 and 2 initially) and then computes the constrained
	// rotational axis as the cross product of ax0 and ax1.
	// the sin and cos of the angle between axis 0 and 1 is computed, this comes
	// from dot and cross product rules.
	void HINGE2_GET_AXIS_INFO(out Vector3 ax0, out Vector3 ax1, out Vector3 axis, out float sin_angle, out float cos_angle)
	{
		ax0 = node0.body.transform.TransformDirection(axis0);
		ax1 = node1.body.transform.TransformDirection(axis1);
		axis = Vector3.Cross(ax0, ax1);
		sin_angle = axis.magnitude; //dSqrt(axis[0] * axis[0] + axis[1] * axis[1] + axis[2] * axis[2]);
		cos_angle = Vector3.Dot(ax0, ax1);
	}
	
	public override void getInfo2(ArraySegment<Constraint> J)
	{
		// get information we need to set the hinge row
		float s, c;
		Vector3 q;
		Vector3 ax0, ax1;
		HINGE2_GET_AXIS_INFO(out ax0, out ax1, out q, out s, out c);
		q.Normalize();     // @@@ quicker: divide q by s ?

		// set the three ball-and-socket rows (aligned to the suspension axis ax0)
		setBall2(J, anchor0, anchor1, ax0, susp_erp, susp_cfm, susp_preload);

		// set the hinge row
		J.Array[J.Offset + 3].J1a = q;
		if (node1.body != null)
		{
			J.Array[J.Offset + 3].J2a = -q;
		}

		// compute the right hand side for the constrained rotational DOF.
		// axis 1 and axis 2 are separated by an angle `theta'. the desired
		// separation angle is theta0. sin(theta0) and cos(theta0) are recorded
		// in the joint structure. the correcting angular velocity is:
		//   |angular_velocity| = angle/time = erp*(theta0-theta) / stepsize
		//                      = (erp*fps) * (theta0-theta)
		// (theta0-theta) can be computed using the following small-angle-difference
		// approximation:
		//   theta0-theta ~= tan(theta0-theta)
		//                 = sin(theta0-theta)/cos(theta0-theta)
		//                 = (c*s0 - s*c0) / (c*c0 + s*s0)
		//                 = c*s0 - s*c0         assuming c*c0 + s*s0 ~= 1
		// where c = cos(theta), s = sin(theta)
		//       c0 = cos(theta0), s0 = sin(theta0)

		float k = Constraint.fps * erp;
		J.Array[J.Offset + 3].c = k * (c0 * s - s0 * c);
		J.Array[J.Offset + 3].cfm = cfm;

		// if the axis1 hinge is powered, or has joint limits, add in more stuff
		int row = 4 + limot0.addLimot(this, J, 4, ax0, true);

		// if the axis2 hinge is powered, add in more stuff
		row += limot1.addLimot(this, J, row, ax1, true);

		// set parameter for the suspension
		//J[info + 0].cfm = susp_cfm;
	}

	public override void InitAfterResetScales()
	{
		TFRigidbody b0 = node0.body;
		TFRigidbody b1 = node1.body;

		Assert.IsTrue(b0 != null && b1 != null, "TFHinge2 attached to null body");
		if (b0 == null || b1 == null)
			return;

		anchor0 = b0.transform.InverseTransformPoint(transform.position);
		anchor1 = b1.transform.InverseTransformPoint(transform.position);
		axis0 = b0.transform.InverseTransformDirection(transform.up);
		axis1 = b1.transform.InverseTransformDirection(transform.right);

		s0 = 1f;
		c0 = 0f;

		makeHinge2V0andV1();
	}

	void makeHinge2V0andV1()
	{
		// get axis 0 and 1 in world space
		Vector3 waxis0, waxis1, v;
		waxis0 = node0.body.transform.TransformDirection(axis0);
		waxis1 = node1.body.transform.TransformDirection(axis1);

		// don't do anything if the waxis0 or waxis1 vectors are zero or the same
		if ((waxis0 == Vector3.zero) || (waxis1 == Vector3.zero) || (waxis0 == waxis1))
			return;

		// modify waxis1 so it's perpendicular to waxis0
		float k = Vector3.Dot(waxis0, waxis1);
		waxis1 -= k * waxis0;
		waxis1.Normalize();

		// make v0 = axis1, v1 = axis0 x axis1
		v = Vector3.Cross(waxis0, waxis1);
		v0 = node0.body.transform.InverseTransformDirection(waxis1);
		v1 = node0.body.transform.InverseTransformDirection(v);
	}

	internal void setBall2(ArraySegment<Constraint> J,
				Vector3 anchor0, Vector3 anchor1,
				Vector3 axis, float erp1, float cfm1, float preload1)
	{
		// anchor points in global coordinates with respect to body PORs.
		Vector3 a0, a1;

		// get vectors normal to the axis. in setBall() axis,q1,q2 is [1 0 0],
		// [0 1 0] and [0 0 1], which makes everything much easier.
		Vector3 q0, q1;
		axis.PlaneSpace(out q0, out q1);

		// set jacobian
		J.Array[J.Offset + 0].J1l = axis;
		J.Array[J.Offset + 1].J1l = q0;
		J.Array[J.Offset + 2].J1l = q1;
		a0 = node0.body.transform.TransformDirection(anchor0);
		J.Array[J.Offset + 0].J1a = Vector3.Cross(a0, axis);
		J.Array[J.Offset + 1].J1a = Vector3.Cross(a0, q0);
		J.Array[J.Offset + 2].J1a = Vector3.Cross(a0, q1);

		// set right hand side - measure error along (axis,q0,q1)
		float k1 = Constraint.fps * erp1;
		float k = Constraint.fps * erp;

		a0 += node0.body.transform.position;

		if (node1.body != null)
		{
			J.Array[J.Offset + 0].J2l = -axis;
			J.Array[J.Offset + 1].J2l = -q0;
			J.Array[J.Offset + 2].J2l = -q1;
			a1 = node1.body.transform.TransformDirection(anchor1);
			Vector3 ma1 = -a1;
			J.Array[J.Offset + 0].J2a = Vector3.Cross(ma1, axis);
			J.Array[J.Offset + 1].J2a = Vector3.Cross(ma1, q0);
			J.Array[J.Offset + 2].J2a = Vector3.Cross(ma1, q1);

			a1 += node1.body.transform.position;
			J.Array[J.Offset + 0].c = k1 * (Vector3.Dot(axis, a1) - Vector3.Dot(axis, a0) + preload1);
			J.Array[J.Offset + 1].c = k * (Vector3.Dot(q0, a1) - Vector3.Dot(q0, a0));
			J.Array[J.Offset + 2].c = k * (Vector3.Dot(q1, a1) - Vector3.Dot(q1, a0));
			J.Array[J.Offset + 0].cfm = cfm1;
			J.Array[J.Offset + 1].cfm = cfm;
			J.Array[J.Offset + 2].cfm = cfm;
		}
		else
		{
			J.Array[J.Offset + 0].c = k1 * (Vector3.Dot(axis, anchor1) - Vector3.Dot(axis, a0) + preload1);
			J.Array[J.Offset + 1].c = k * (Vector3.Dot(q0, anchor1) - Vector3.Dot(q0, a0));
			J.Array[J.Offset + 2].c = k * (Vector3.Dot(q1, anchor1) - Vector3.Dot(q1, a0));
			J.Array[J.Offset + 0].cfm = cfm1;
			J.Array[J.Offset + 1].cfm = cfm;
			J.Array[J.Offset + 2].cfm = cfm;
		}
	}
}
