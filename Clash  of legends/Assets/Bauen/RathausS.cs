using UnityEngine;
using System.Collections;

public class RathausS : MonoBehaviour {
	public GameObject RathausPrefab;
	public Transform spawnPoint;
	public Transform Drehung;
	public GameObject spawnPointa;
	private spawnPoint a;
	//double land;
	public GameObject AbrissHintergrund;
	private AbrissHintergrundS b;
	int hatschongedreht;
	// Use this for initialization
	//int anfangrathaus;
	public int einmal;
public int abriss;
	void Start () {
		a = spawnPointa.GetComponent<spawnPoint > ();
		b = AbrissHintergrund.GetComponent<AbrissHintergrundS > ();
	}
	
	void OnMouseDown(){
		if (b.abriss == 1) {
			Destroy (gameObject);
			//transform.Rotate(270,0,0,Space.World);
		}
	}
	// Update is called once per frame
	void Update () {
		if (a.los == 5) {
			Instantiate (RathausPrefab, new Vector3 (0f, 10000f, 0f), Drehung.rotation);
			a.los = 0;
		}
		if (a.los == 1) {
			Debug.Log ("los = 1");
			abriss = a.abriss;
			//if(hatschongedreht == 0){
				transform.Rotate(0,45,0);
			//	hatschongedreht = 1;
			//}
			Instantiate (RathausPrefab, spawnPoint.position, Drehung.rotation);
			a.bBustabe = 0;
			a.bZahl = 0;
			a.los = 0;
			GetComponent<Renderer> ().enabled = true;
			a.hatschongebaut = 1;
			
		}

		if (a.abriss != 0) {
			if (a.abriss == abriss * 10) {
				Debug.Log ("zerstört");
				Destroy (gameObject);
			}
		}
}
}
