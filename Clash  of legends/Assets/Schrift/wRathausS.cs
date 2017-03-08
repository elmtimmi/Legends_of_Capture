using UnityEngine;
using System.Collections;

public class wRathausS : MonoBehaviour {
	public GameObject Bauen;
	private BauenS a;
	// Use this for initialization
	void Start () {
		a = Bauen.GetComponent<BauenS> ();
	}
	
	// Update is called once per frame
	void Update () {
	if (a.gebäude == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer>().enabled = false;
		}
	}
}
