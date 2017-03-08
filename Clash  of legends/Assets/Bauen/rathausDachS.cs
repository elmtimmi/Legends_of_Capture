using UnityEngine;
using System.Collections;

public class rathausDachS : MonoBehaviour {
	public GameObject AbrissHintergrund;
	private AbrissHintergrundS b;
	// Use this for initialization
	void Start () {
		b = AbrissHintergrund.GetComponent<AbrissHintergrundS > ();
	}
	
	// Update is called once per frame
		void OnMouseDown(){
			if (b.abriss == 1) {
				Destroy (gameObject);
			}
	}
}
