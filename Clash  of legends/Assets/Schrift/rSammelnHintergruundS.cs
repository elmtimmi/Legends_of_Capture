using UnityEngine;
using System.Collections;

public class rSammelnHintergruundS : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	public GameObject  rSammeln;
	private  rSammelnS b;
	// Use this for initialization
	void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		b =rSammeln.GetComponent<rSammelnS> ();
	}

	// Update is called once per frame
	void Update () {
		if (a.darfnochwasmachen == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer> ().enabled = false;
		} 
	}
	void OnMouseDown(){
		b.sammeln = 1;
		a.darfnochwasmachen = 0;
	}
}
