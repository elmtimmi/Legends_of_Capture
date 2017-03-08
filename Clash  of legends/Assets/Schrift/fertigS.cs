using UnityEngine;
using System.Collections;

public class fertigS : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	int durchlauf;
	int darf1;
	int einmal;
	// Use this for initialization
	void Start(){
		a = RotDran.GetComponent<Rotistdran> ();
		a.f = 1;
		darf1 = 1;
		GetComponent<Renderer> ().enabled = false;
	}
	void OnMouseDown(){
		a.f = 0;
		darf1 = 0;
		//Debug.Log ("f = 0");
	}

	void Update(){
		if (a.start == 1) {
			if(einmal == 0){
				a.anDerReihe = 2;
				a.darfnochwasmachen = 1;
			a.f = 1;
				einmal= 1;
			}
			if (a.map == 1) {

				GetComponent<Renderer> ().enabled = true;
			}
			if (a.map == 2) {

				GetComponent<Renderer> ().enabled = true;
			}
			if (a.map > 2) {
				
				GetComponent<Renderer> ().enabled = true;
			}
			if (darf1 == 0) {
				//darf1 = 0;
				if (durchlauf == 0) {
					durchlauf ++;
					a.f = 0;
					//Debug.Log ("f = 0");
				} else
					durchlauf = 0;
				//Debug.Log ("durchlauf = " + durchlauf);
				darf1 = 1;
			} else

		if (darf1 == 1) {
				a.f = 1;
				///Debug.Log ("f = 1");
			}
		}
	}
}
