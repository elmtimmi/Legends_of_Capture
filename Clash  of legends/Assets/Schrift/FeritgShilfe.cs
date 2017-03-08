using UnityEngine;
using System.Collections;

public class FeritgShilfe : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
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
			if (a.map == 1) {
			//	Vector3 temp = new Vector3 (177f, 450, 211);
			//	this.transform.position = temp;
					GetComponent<Renderer> ().enabled = true;
			}
			if (a.map == 2) {
			//	Vector3 temp = new Vector3 (262f, 650, 101f);
			//	this.transform.position = temp;
				GetComponent<Renderer> ().enabled = true;
			}
			if (a.map > 2) {
			//	Vector3 temp = new Vector3 (262f, 650, 101f);
				//this.transform.position = temp;
				GetComponent<Renderer> ().enabled = true;
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
            }else
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