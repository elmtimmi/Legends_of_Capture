using UnityEngine;
using System.Collections;

public class VerschiebenS : MonoBehaviour {
	
	public GameObject RotDran;
	private Rotistdran a;
	public int verschieben;
    int darfnoch;
    int einmala;
    int einmalb;
    Rect butRect;
    float ctrlWidh = 160;
    float ctrlHight = 30;
    void OnMouseDown(){
		Debug.Log ("down");
		verschieben = 1;
		a.darfnochwasmachen = 0;
	}
	// Use this for initialization
	void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		GetComponent<Renderer> ().enabled = false;
	}

    // Update is called once per frame
    void Update()
    {
        if (a.spielvorbei == 1)
        {
            verschieben = 0;
        }
        if (a.start == 1)
        {
            if (a.map == 1)
            {
               // Vector3 temp = new Vector3(179f, 450, 221);
               // this.transform.position = temp;
            }
            if (a.map == 2)
            {
             //   Vector3 temp = new Vector3(264f, 650, 111f);
             //   this.transform.position = temp;
            }
            if (a.map == 3)
            {
            //    Vector3 temp = new Vector3(264f, 650, 111f);
              //  this.transform.position = temp;
            }
            if (a.map == 4)
            {
             //   Vector3 temp = new Vector3(264f, 650, 111f);
            //    this.transform.position = temp;
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
            if (a.darfnochwasmachen == 1)
            {
                GetComponent<Renderer>().enabled = true;
            }
            else
            {
                GetComponent<Renderer>().enabled = false;
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                verschieben = 0;
            }
            if (a.f == 0)
            {
                verschieben = 0;
            }

        }
    }
}