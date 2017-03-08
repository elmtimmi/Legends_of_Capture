using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segel : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran b;
	void OnMouseDown(){
		Debug.Log ("schiff");
		b.p = transform.position;
	}
	// Use this for initialization
	void Start () {
		b = RotDran.GetComponent<Rotistdran> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
