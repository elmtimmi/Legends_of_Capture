using UnityEngine;
using System.Collections;

public class ausbildenHintergrundS : MonoBehaviour {
	public GameObject Ausbilden;
	private Ausbilden a;
	public GameObject RotDran;
	private Rotistdran b;

	void Start () {
		a = Ausbilden.GetComponent<Ausbilden> ();
		b = RotDran.GetComponent<Rotistdran> ();
		GetComponent<Renderer> ().enabled = false;
	}
	
	void OnMouseDown(){
		Debug.Log ("ausbilden = 1");
		a.ausbilden = 1;
		b.darfnochwasmachen = 0;
	}
	
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if (b.darfnochwasmachen == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer> ().enabled = false;
		} 
	}
}