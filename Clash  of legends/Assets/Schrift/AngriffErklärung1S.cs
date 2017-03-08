using UnityEngine;
using System.Collections;

public class AngriffErklärung1S : MonoBehaviour {
	public GameObject AngriffVerschiebung;
	private AngriffS a;
	// Use this for initialization
	void Start () {
		a = AngriffVerschiebung.GetComponent<AngriffS> ();
	}
	
	// Update is called once per frame
	void Update () {
	if (a.angriff == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer>().enabled = false;
		}

	}
}
