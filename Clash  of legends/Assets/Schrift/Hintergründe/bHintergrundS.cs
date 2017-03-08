using UnityEngine;
using System.Collections;

public class bHintergrundS : MonoBehaviour {
	public GameObject Bauen;
	private BauenS a;
	public GameObject RotDran;
	private Rotistdran b;

	void OnMouseDown(){
		a.bauen = 1;
		b.darfnochwasmachen = 0;
        a.bauenn = 1;
	}
	
	// Use this for initialization
	void Start () {
		a = Bauen.GetComponent<BauenS> ();
		b = RotDran.GetComponent<Rotistdran> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (b.darfnochwasmachen == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else if(a.darfwürfeln == 0){
				GetComponent<Renderer> ().enabled = false;

		} 

	}
}
