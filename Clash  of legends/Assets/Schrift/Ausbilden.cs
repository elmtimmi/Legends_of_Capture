using UnityEngine;
using System.Collections;

public class Ausbilden : MonoBehaviour {

	public GameObject RotDran;
	private Rotistdran a;
	public int ausbilden;
	Rect butRect;
	float ctrlWidh = 160;
	float ctrlHight = 30;
	int einmal;
    int darfnoch;
    int einmala;
    int einmalb;

    void OnMouseDown(){
		Debug.Log ("ausbilden = 1");
		ausbilden = 1;
		a.darfnochwasmachen = 0;
	}
	// Use this for initialization
	void OnGUI(){
		if (a.stamm == 4) {
			if (ausbilden == 1) {
				if (a.coints > 1) {
					butRect = new Rect ((Screen.width - ctrlWidh) - 80, 0, ctrlWidh + 70, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 4;
                    if (einmal == 0)
                    {
                        if (GUI.Button(butRect, "3 Truppen beschwören für 2 Rubine"))
                        {
                            ausbilden = 2;
                            einmal = 1;
                            if (a.anDerReihe == 1)
                            {
                                a.spez1++;
                            }
                            if (a.anDerReihe == 2)
                            {
                                a.spez2++;
                            }
                            if (a.anDerReihe == 3)
                            {
                                a.spez3++;
                            }
                            if (a.anDerReihe == 4)
                            {
                                a.spez4++;
                            }
                            if (a.anDerReihe == 1)
                            {
                                a.rotCoints -= 3;
                            }
                            if (a.anDerReihe == 2)
                            {
                                a.blauCionts -= 3;
                            }
                            if (a.anDerReihe == 3)
                            {
                                a.grünCoints -= 3;
                            }
                            if (a.anDerReihe == 4)
                            {
                                a.gelbCoints -= 3;
                            }
                        }
                    }
				}
			}
		}
        if (darfnoch == 1)
        {
            if(ausbilden == 4)
            {
                ausbilden = 0;
            }
        }
            if (ausbilden == 1)
            {
                if (a.coints > 2)
                {
                    if (darfnoch == 0)
                    {
                        if (a.stamm == 2)
                        {
                            butRect = new Rect((Screen.width - ctrlWidh) - 80, 0, ctrlWidh + 70, ctrlHight);
                            butRect.y = (Screen.height - ctrlHight) / 4;
                            if (GUI.Button(butRect, "Fluch der Truppen für 3 Rubine"))
                            {
                                if (a.coints > 2)
                                {
                                    ausbilden = 4;
                                    if (a.anDerReihe == 1)
                                    {
                                        a.rotCoints -= 3;
                                    }
                                    if (a.anDerReihe == 2)
                                    {
                                        a.blauCionts -= 3;
                                    }
                                    if (a.anDerReihe == 3)
                                    {
                                        a.grünCoints -= 3;
                                    }
                                    if (a.anDerReihe == 4)
                                    {
                                        a.gelbCoints -= 3;
                                    }
                                    darfnoch = 1;
                                    a.coints -= 3;
                                }
                            }
                        }

                    }
                }
            }
    }
	void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		GetComponent<Renderer> ().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (a.start == 1) {
			if (a.map == 1) {
			//	Vector3 temp = new Vector3 (179f, 450, 224);
			//	this.transform.position = temp;
			}
			if (a.map == 2) {
			//	Vector3 temp = new Vector3 (264f, 650, 114f);
			//	this.transform.position = temp;
			}
			if (a.map == 3) {
			//	Vector3 temp = new Vector3 (264f, 650, 114f);
			//	this.transform.position = temp;
			}
			if (a.map == 4) {
			//	Vector3 temp = new Vector3 (264f, 650, 114f);
				//this.transform.position = temp;
			}
			if (a.darfnochwasmachen == 1) {
				GetComponent<Renderer> ().enabled = true;
			} else {
				GetComponent<Renderer> ().enabled = false;
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
            if (Input.GetKeyDown (KeyCode.F)) {
				ausbilden = 0;
                darfnoch = 0;
			
			
			}
			if (a.f == 0) {
				ausbilden = 0;
                darfnoch = 0;
            }
		}
	}
}