using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schiffraduisS : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;

	// Use this for initialization
	void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
	}
	void OnTriggerEnter (Collider other) {
		Debug.Log("contact.point, contact.normal * 10, Color.white");
		
	}
	// Update is called once per frame
	void Update(){
		this.transform.position =  a.p;

}
}
