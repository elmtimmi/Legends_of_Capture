using UnityEngine;
using System.Collections;

public class elfRathaus : MonoBehaviour {
	public GameObject elfRathausPrefab;
	public Transform spawnPoint;
	public Transform Drehung2;
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
		if (a.los3 == 5) {
			Instantiate (elfRathausPrefab, new Vector3 (0f, 10000f, 0f),Drehung2.rotation);
			a.los3 = 0;
		}
		if (a.los3 == 1) {
			Debug.Log ("los = 1");
			abriss = a.abriss;
			//if(hatschongedreht == 0){
			transform.Rotate(0,45,0);
			//	hatschongedreht = 1;
			//}
			Instantiate (elfRathausPrefab, new Vector3 (a.c3, 10f, a.v3),Drehung2.rotation);
			a.bBustabe = 0;
			a.bZahl = 0;
			a.los3 = 0;
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
