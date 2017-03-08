using UnityEngine;
using System.Collections;

public class GrünistdranS : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
    int einmala;
    int einmalb;

    // Use this for initialization
    void Start () {
		gameObject.GetComponent<Renderer>().material.color = Color.green;
		a = RotDran.GetComponent<Rotistdran> ();
		GetComponent<Renderer> ().enabled = false;
		
	} 
	
	// Update is called once per frame
	void Update () {
		if (a.start == 1) {
            if (a.darfnochwasmachen == 0)
            {
                if (einmala == 0)
                {
                    Vector3 temp = new Vector3(-100f, 0, 0f);
                    this.transform.position += temp;
                    einmala = 1;
                    einmalb = 0;
                }
            }
            else
  if (einmalb == 0)
            {
                Vector3 temp = new Vector3(-100f, 0, 0f);
                this.transform.position -= temp;
                einmalb = 1;
                einmala = 0;
            }
            if (a.anDerReihe == 3) {
				GetComponent<Renderer> ().enabled = true;
			
			} else {
				GetComponent<Renderer> ().enabled = false;
			
			}
		}
	}
}
