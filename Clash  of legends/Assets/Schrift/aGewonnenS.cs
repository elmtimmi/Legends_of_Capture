using UnityEngine;
using System.Collections;

public class aGewonnenS : MonoBehaviour {
	public GameObject AngriffVerschiebung;
	private ATruppen a;
	// Use this for initialization
	void Start () {
		a = AngriffVerschiebung.GetComponent<ATruppen> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (a.aGewonnen == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer> ().enabled = false;
		}
	}
}
