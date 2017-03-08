using UnityEngine;
using System.Collections;

public class untotBrückengebäude : MonoBehaviour {
	public GameObject elfKasernePrefab;
	public Transform spawnPoint;
	public Transform Drehung2;
	public GameObject spawnPointa;
	private spawnPoint a;
	public int abriss;	
	// Use this for initialization
	void Start () {
		a = spawnPointa.GetComponent<spawnPoint > ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (a.brück2 == 1) {
			Instantiate (elfKasernePrefab, new Vector3 (0f, 10000f, 0f), Drehung2.rotation);
			a.brück2 = 0;
		}
		if (a.los2 == 3) {
			Debug.Log ("los = 2");
			abriss = a.abriss;
			Instantiate (elfKasernePrefab, new Vector3 (a.c3, 10f, a.v3), Drehung2.rotation);
			a.bBustabe = 0;
			a.bZahl = 0;
			a.los2 = -1;
			GetComponent<Renderer> ().enabled = true;
			
			
		}
		if (a.abriss != 0) {
			if (a.abriss == abriss * 10) {
				Debug.Log ("zerstört");
				Destroy (gameObject);
			}
		}
	}
}