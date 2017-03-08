using UnityEngine;
using System.Collections;

public class zweiSpieler : MonoBehaviour {
	public GameObject wieVieleSpieler;
	private wieVieleSpielerS a;
	void OnMouseDown(){
		a.spieler = 2;
	}
	// Use this for initialization
	void Start () {
		a =wieVieleSpieler.GetComponent<wieVieleSpielerS> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
