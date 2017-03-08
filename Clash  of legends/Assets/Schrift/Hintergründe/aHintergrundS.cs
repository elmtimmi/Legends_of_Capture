using UnityEngine;
using System.Collections;

public class aHintergrundS : MonoBehaviour {
	public GameObject AngriffVerschiebung;
	private AngriffS a;
	public GameObject RotDran;
	private Rotistdran b;

	void OnMouseDown(){
		a.angriff = 1;
		b.darfnochwasmachen = 0;
	}

	// Use this for initialization
	void Start () {
		a = AngriffVerschiebung.GetComponent<AngriffS> ();
		b = RotDran.GetComponent<Rotistdran> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (b.darfnochwasmachen == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer> ().enabled = false;
		} 
	}
}
