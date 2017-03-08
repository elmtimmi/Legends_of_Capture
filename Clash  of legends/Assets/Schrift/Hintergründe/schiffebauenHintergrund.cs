using UnityEngine;
using System.Collections;

public class schiffebauenHintergrund : MonoBehaviour {
	public GameObject Ausbilden;
	private Ausbilden a;
	public GameObject RotDran;
	private Rotistdran b;
	public GameObject Hafen;
	private hafensteeg c;
	// Use this for initialization
	void Start () {
		a = Ausbilden.GetComponent<Ausbilden> ();
		b = RotDran.GetComponent<Rotistdran> ();
		c = Hafen.GetComponent<hafensteeg> ();
		GetComponent<Renderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void OnMouseDown(){
		Debug.Log ("ausbilden = 3");
		a.ausbilden = 3;
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
		if (b.getland != 0) {

		}
	}
}