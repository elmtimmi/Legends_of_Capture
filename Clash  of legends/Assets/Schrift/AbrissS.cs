using UnityEngine;
using System.Collections;

public class AbrissS : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran b;
	//public GameObject AbrissHintergrund;
//	private AbrissHintergrundS a;
	// Use this for initialization
	void Start () {
		//a = AbrissHintergrund.GetComponent<AbrissHintergrundS > ();
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
