using UnityEngine;
using System.Collections;

public class G : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	// Use this for initialization
	void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (a.map == 1) {
			GetComponent<Renderer> ().enabled = false;
		}
		if (a.map == 2) {
			GetComponent<Renderer> ().enabled = true;
		}
		if (a.map == 3) {
			GetComponent<Renderer> ().enabled = true;
		}
	}
}

