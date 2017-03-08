using UnityEngine;
using System.Collections;

public class FollowBuggy : MonoBehaviour 
{
	public Transform buggy;
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt(buggy, Vector3.up);
	}
}
