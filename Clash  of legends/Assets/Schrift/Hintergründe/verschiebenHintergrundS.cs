using UnityEngine;
using System.Collections;

public class verschiebenHintergrundS : MonoBehaviour {
	public GameObject Verschieben;
	private VerschiebenS a;
	public GameObject RotDran;
	private Rotistdran b;
	
	void OnMouseDown(){
		a.verschieben = 1;
		b.darfnochwasmachen = 0;
	}
	
	// Use this for initialization
	void Start () {
		a = Verschieben.GetComponent<VerschiebenS> ();
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
