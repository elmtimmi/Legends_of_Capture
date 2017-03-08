using UnityEngine;
using System.Collections;

public class dreiSpieler : MonoBehaviour {
	public GameObject wieVieleSpieler;
	private wieVieleSpielerS a;
	public GameObject RotDran;
	private Rotistdran b;
	void OnMouseDown(){
		a.spieler = 3;
		b.länderGrün = 1;
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
