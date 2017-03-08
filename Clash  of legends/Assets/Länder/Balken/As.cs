using UnityEngine;
using System.Collections;

public class As : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	// Use this for initialization
	void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
	}
	
	// Update is called once per frame
	void Update () {
        if (a.map == 1)
        {
            GetComponent<Renderer>().enabled = false;
        }
        else if (a.map == 4)
        {
            GetComponent<Renderer>().enabled = false;
        }
        else
        GetComponent<Renderer> ().enabled = true;
	}
}