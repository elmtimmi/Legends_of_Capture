using UnityEngine;
using System.Collections;

public class version : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
    int einmala;
    int einmalb;
    // Use this for initialization
    void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
	//	GetComponent<Renderer> ().enabled = false;
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
    }
}
