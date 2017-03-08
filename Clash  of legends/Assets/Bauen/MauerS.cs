using UnityEngine;
using System.Collections;

public class MauerS : MonoBehaviour {
	public GameObject MauerPrefab;
	public Transform spawnPoint;
	public GameObject spawnPointa;
	private spawnPoint a;
	public GameObject AbrissHintergrund;
	private AbrissHintergrundS b;
public int abriss;
	int einmal;
	// Use this for initialization
	
	void OnMouseDown(){
		if (b.abriss == 1) {
			Destroy (gameObject);
		}
	}
	void Start () {
		a = spawnPointa.GetComponent<spawnPoint > ();
		b = AbrissHintergrund.GetComponent<AbrissHintergrundS > ();
	}
	
	// Update is called once per frame
	void Update () {
		if (a.einmal == 0) {
			Instantiate (MauerPrefab, new Vector3 (0f, 10000f, 0f), spawnPoint.rotation);
			a.einmal = 1;
		}
	if (a.los == 4) {
			if (a.abriss > 0) {
				abriss = a.abriss;
				Instantiate (MauerPrefab, spawnPoint.position, spawnPoint.rotation);
				Debug.Log ("mauer gebaut");
				a.bBustabe = 0;
				a.bZahl = 0;
				a.los = 0;
				GetComponent<Renderer> ().enabled = true;
				abriss = 0;
			}
		}
		if (a.abriss != 0) {
			if (a.abriss == abriss * 10) {
				Debug.Log ("zerstört");
				Destroy (gameObject);
			}
		}
	}
}
