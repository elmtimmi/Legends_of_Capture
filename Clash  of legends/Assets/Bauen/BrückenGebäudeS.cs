using UnityEngine;
using System.Collections;

public class BrückenGebäudeS : MonoBehaviour {

	public GameObject BrückenGebäudePrefab;
	public Transform spawnPoint;
	public Transform Drehung;
	public GameObject spawnPointa;
	private spawnPoint a;
	public GameObject AbrissHintergrund;
	private AbrissHintergrundS b;
	public int abriss;
	// Use this for initialization
	void Start () {
		a = spawnPointa.GetComponent<spawnPoint > ();
		b = AbrissHintergrund.GetComponent<AbrissHintergrundS > ();
	}
	
	void OnMouseDown(){
		if (b.abriss == 1) {
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		if (a.brück == 1) {
			Instantiate (BrückenGebäudePrefab, new Vector3 (0f, 10000f, 0f), Drehung.rotation);
			a.brück = 0;
		}
		if (a.los == 3) {
			Debug.Log ("los = 2");
			abriss = a.abriss;
			Instantiate (BrückenGebäudePrefab, spawnPoint.position, Drehung.rotation);
			a.bBustabe = 0;
			a.bZahl = 0;
			a.los = 0;
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
