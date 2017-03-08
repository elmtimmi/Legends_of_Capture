using UnityEngine;
using System.Collections;

public class blauVerlorenS : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	int wiederholen;
    int einmala;
    int einmalb;
    // Use this for initialization
    void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		gameObject.GetComponent<Renderer>().material.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {
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
        if (a.länderBlau == 0){
			a.blaulebt = 0;
			if(wiederholen < 500){
				GetComponent<Renderer> ().enabled = true;
				wiederholen ++;
			}else GetComponent<Renderer> ().enabled = false;
		}else GetComponent<Renderer> ().enabled = false;
	}
}

