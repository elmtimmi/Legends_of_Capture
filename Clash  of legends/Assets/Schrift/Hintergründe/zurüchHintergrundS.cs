using UnityEngine;
using System.Collections;

public class zurüchHintergrundS : MonoBehaviour {
	public GameObject regelnHintergrund;
	private regelnHintergrundS a;
	// Use this for initialization
	void Start () {
		a = regelnHintergrund.GetComponent<regelnHintergrundS> ();
	}
	void OnMouseDown(){
		a.regeln = 0;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
