using UnityEngine;
using System.Collections;
using System;
using TF;

public class buggy : MonoBehaviour 
{
	public Camera[] cameras;
	int cameraId = 0;

	public TFRigidbody chassis;
	public TFHinge2[] steeringWheels;
	public TFHinge2[] drivingWheels;

	public float maxVel = 10f;
	public float fForward = 1f;
	public float fNeutral = 0.1f;
	public float fReverse = 0.1f;
	public float spring = 1f;
	public float damping = 1f;

	void Start()
	{
		TFHinge2[] allWheels = gameObject.GetComponentsInChildren<TFHinge2>();

		foreach (TFHinge2 wheel in allWheels)
		{
			wheel.body1.gameObject.GetComponent<TFCollider>().contactSetup += contactSetup;
		}

		foreach (Camera camera in cameras)
		{
			camera.enabled = false;
		}

		cameras[cameraId].enabled = true;
	}

	private void contactSetup(TFCollider collider, TFContact contact)
	{
		contact.contactInfo.fdir1 = collider.transform.up;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			cameras[cameraId].enabled = false;
			cameraId++;
			cameraId %= cameras.Length;
			cameras[cameraId].enabled = true;
		}

		if (Input.GetKey(KeyCode.Space))
		{
			chassis.velocities.Zero();

			Vector3 pos = chassis.transform.position;
			pos.y = 1f;
			chassis.transform.position = pos;

			Vector3 forward = chassis.transform.forward;
			forward.y = 0f;
			forward.Normalize();
			chassis.transform.LookAt(chassis.transform.position + forward, Vector3.up);
		}
	}

	void FixedUpdate()
	{ 
		float vel;
		float fmax;

		if (Input.GetKey(KeyCode.UpArrow))
		{
			vel = -this.maxVel;
			fmax = fForward;
		}
		else if (Input.GetKey(KeyCode.DownArrow))
		{
			vel = this.maxVel;
			fmax = fReverse;
		}
		else
		{
			vel = 0f;
			fmax = fNeutral;
		}

		foreach (TFHinge2 wheel in drivingWheels)
		{
			wheel.limot1.vel = vel;
			wheel.limot1.fmax = fmax;
		}

		float steer = 0f;

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			steer += 0.5f;
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			steer -= 0.5f;
		}

		foreach (TFHinge2 wheel in steeringWheels)
		{
			float v = Mathf.Clamp(steer - wheel.MeasureHinge2Angle(), -0.1f, 0.1f);
			v *= 100f;
			wheel.limot0.vel = v;
			wheel.limot0.fmax = 1f;
			wheel.limot0.lostop = -1f;
			wheel.limot0.histop = 1f;
			wheel.limot0.fudge_factor = 0.1f;
		}
		
		float susp_erp = Time.fixedDeltaTime * this.spring / (Time.fixedDeltaTime * this.spring + this.damping);
		float susp_cfm = 1f / (Time.fixedDeltaTime * this.spring + this.damping);

		TFHinge2[] allWheels = gameObject.GetComponentsInChildren<TFHinge2>();

		foreach (TFHinge2 wheel in allWheels)
		{
			wheel.susp_cfm = susp_cfm;
			wheel.susp_erp = susp_erp;
		}
	}

	void OnGUI()
	{
		Rect rect = new Rect(0f, Screen.height - 25f, Screen.width, 25f);
		GUI.Box(rect, "Arrows to control buggy, Tab to switch between cameras, Space to reset buggy");
	}
}
