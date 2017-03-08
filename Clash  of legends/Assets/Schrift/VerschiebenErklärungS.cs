using UnityEngine;
using System.Collections;

public class VerschiebenErklärungS : MonoBehaviour {
	public GameObject Verschiebung;
	private VerschiebenS a;
	// Use this for initialization
	void Start () {
		a = Verschiebung.GetComponent<VerschiebenS> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (a.verschieben == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer>().enabled = false;
		}
		
	}
}