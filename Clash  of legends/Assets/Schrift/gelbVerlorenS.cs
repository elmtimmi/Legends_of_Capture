using UnityEngine;
using System.Collections;

public class gelbVerlorenS : MonoBehaviour {

	
	public GameObject RotDran;
	private Rotistdran a;
	int wiederholen;
	public GameObject wieVieleSpieler;
	private wieVieleSpielerS b;
    int einmala;
    int einmalb;
    // Use this for initialization
    void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		gameObject.GetComponent<Renderer>().material.color = Color.yellow;
		b = wieVieleSpieler.GetComponent<wieVieleSpielerS> ();
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
        if (b.spieler == 4) {
			if (a.länderGelb == 0) {
				a.gelblebt = 0;
				if (wiederholen < 500) {
					GetComponent<Renderer> ().enabled = true;
					wiederholen ++;
				} else
					GetComponent<Renderer> ().enabled = false;
			} else {
				GetComponent<Renderer> ().enabled = false;
				a.gelblebt = 1;
			}
		} else {
			GetComponent<Renderer> ().enabled = false;
			a.gelblebt = 1;
		}
	}
}
