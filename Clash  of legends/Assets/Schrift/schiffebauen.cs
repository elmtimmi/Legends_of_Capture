using UnityEngine;
using System.Collections;

public class schiffebauen : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	int schiffeausbilden;
    // Use this for initialization
    int einmala;
    int einmalb;
    void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		GetComponent<Renderer> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (a.start == 1) {
			if(a.map < 4){
				gameObject.SetActive (false);
			}
			if (a.map == 4) {
				//Vector3 temp = new Vector3 (264f, 650, 105f);
				//this.transform.position = temp;
			}
			if (a.darfnochwasmachen == 1) {
				GetComponent<Renderer> ().enabled = true;
			} else {
				GetComponent<Renderer> ().enabled = false;
			} 

			if (Input.GetKeyDown (KeyCode.F)) {
				schiffeausbilden = 0;
				
				
			}
			if (Input.GetKeyDown (KeyCode.F)) {
				schiffeausbilden = 0;
			}
			if (a.f == 0) {
				schiffeausbilden = 0;
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
        }
	}
}
