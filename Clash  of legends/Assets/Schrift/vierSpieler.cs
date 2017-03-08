using UnityEngine;
using System.Collections;

public class vierSpieler : MonoBehaviour {

	public GameObject wieVieleSpieler;
	private wieVieleSpielerS a;
	public GameObject RotDran;
	private Rotistdran b;
	void OnMouseDown(){
		a.spieler = 4;
		b.länderGrün = 1;
		b.länderGelb = 1;
	}
	// Use this for initialization
	void Start () {
		a =wieVieleSpieler.GetComponent<wieVieleSpielerS> ();
		b = RotDran.GetComponent<Rotistdran> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

