using UnityEngine;
using System.Collections;

public class torS : MonoBehaviour {
	public GameObject MauerPrefab;
	public Transform spawnPoint;
	public GameObject spawnPointa;
	private spawnPoint a;
	public int abriss;
	void Start () {
		a = spawnPointa.GetComponent<spawnPoint > ();
	}
	
	// Update is called once per frame
	void Update () {
		if (a.einmal1 == 0) {
			Instantiate (MauerPrefab, new Vector3 (0f, 10000f, 0f), spawnPoint.rotation);
			a.einmal1 = 1;
		}
		if (a.los == 6) {
			if (a.abriss > 0) {
				abriss = a.abriss;
				Instantiate (MauerPrefab, spawnPoint.position, spawnPoint.rotation);
				a.bBustabe = 0;
				a.bZahl = 0;
				a.los = 0;
				GetComponent<Renderer> ().enabled = true;
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
