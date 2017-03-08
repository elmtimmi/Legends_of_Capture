using UnityEngine;
using System.Collections;

public class AbrissHintergrundS : MonoBehaviour {
	public int abriss;
	public GameObject RotDran;
	private Rotistdran b;
	
	void OnMouseDown(){
		abriss = 1;
	}
	
	// Use this for initialization
	void Start () {
		b = RotDran.GetComponent<Rotistdran> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (b.darfnochwasmachen == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer> ().enabled = false;
		} 
		if (b.f == 0) {
			abriss = 0;
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			abriss = 0;
		}
	}

}
