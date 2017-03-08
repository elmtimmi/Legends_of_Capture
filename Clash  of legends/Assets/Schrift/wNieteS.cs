using UnityEngine;
using System.Collections;

public class wNieteS : MonoBehaviour {
	public GameObject Bauen;
	private BauenS a;
	public GameObject RotDran;
	// Use this for initialization
	void Start () {
		a = Bauen.GetComponent<BauenS> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (a.gebäude == 4) {
			GetComponent<Renderer> ().enabled = true;

}else 
			GetComponent<Renderer> ().enabled = false;
}
}