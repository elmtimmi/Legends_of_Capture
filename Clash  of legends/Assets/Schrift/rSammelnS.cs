using UnityEngine;
using System.Collections;

public class rSammelnS : MonoBehaviour {
	public int sammeln;
	public GameObject RotDran;
	private Rotistdran a;
    int einmala;
    int einmalb;
    // Use this for initialization
    void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		GetComponent<Renderer> ().enabled = false;
	}


	// Update is called once per frame
	void Update () {
		if (a.start == 1) {
			if (a.map == 1) {
				//Vector3 temp = new Vector3 (179f, 450, 218);
				//this.transform.position = temp;
			}
			if (a.map == 2) {
			//	Vector3 temp = new Vector3 (264f, 650, 108f);
				//this.transform.position = temp;
			}
			if (a.map == 3) {
				//Vector3 temp = new Vector3 (264f, 650, 108f);
				//this.transform.position = temp;
			}
			if (a.map == 4) {
				//Vector3 temp = new Vector3 (264f, 650, 108f);
				//this.transform.position = temp;
			}
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
            if (sammeln == 1) {
				if (a.anDerReihe == 1) {
					a.rotCoints ++;
				}
				if (a.anDerReihe == 2) {
					a.blauCionts ++;
				}
				if (a.anDerReihe == 3) {
					a.grünCoints ++;
				}
				if (a.anDerReihe == 4) {
					a.gelbCoints ++;
				}
				if(a.zweirubine == 1){
					if (a.anDerReihe == 1) {
						a.rotCoints ++;
					}
					if (a.anDerReihe == 2) {
						a.blauCionts ++;
					}
					if (a.anDerReihe == 3) {
						a.grünCoints ++;
					}
					if (a.anDerReihe == 4) {
						a.gelbCoints ++;
					}
				}
				sammeln = 0;
			}
			if (a.f == 0) {
				sammeln = 0;
			}
			if (Input.GetKeyDown (KeyCode.F)) {
				sammeln = 0;
			}
			if (a.darfnochwasmachen == 1) {
				GetComponent<Renderer> ().enabled = true;
			} else {
				GetComponent<Renderer> ().enabled = false;
			} 
		}
	}
}
