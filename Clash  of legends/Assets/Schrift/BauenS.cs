using UnityEngine;
using System.Collections;

public class BauenS : MonoBehaviour {
    public GameObject RotDran;
    private Rotistdran a;
    public int gebäude;
    public int bauen;
    public int darfwürfeln;
    public int zweimal;
    public int würfeln;
    public int mauer;
    public int wmauer;
    public int tor;
    public int wtor;
    int darfnoch;
    int hatschon;
    Rect butRect;
    float ctrlWidh = 160;
    float ctrlHight = 30;
    public int darfnicht;
    int einmal;
    int kaserne1;
    int einmal1;
    int rathaus1;
    int brücke1;
    int niete1;
    int hafen1;
    int darfnoche;
    int zweilmalbauen;
    int gebäudenull;
    int Schleife1;
    int einmala;
    int einmalb;
    public int bauenn;
    void OnMouseDown() {
        Debug.Log("down");
        bauen = 1;
        bauenn = 1;
        a.darfnochwasmachen = 0;
    }
    // Use this for initialization
    void Start() {
        a = RotDran.GetComponent<Rotistdran>();
        butRect = new Rect((Screen.width - ctrlWidh) - 50, 0, ctrlWidh + 1, ctrlHight);
        GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame

    void OnGUI()
    {
        if (gebäude == 1)
        {
            Debug.Log("gebäude = 1");
            GUI.Label(new Rect(1050, 100, 550, 500), "Du hast ein Rathaus");
            GUI.Label(new Rect(1050, 115, 570, 500), "gewürfelt!");
            if (rathaus1 < 1)
            {
                rathaus1++;
                if (a.anDerReihe == 1)
                {
                    a.Rathaus1++;
                }
                if (a.anDerReihe == 2)
                {
                    a.Rathaus2++;
                }
                if (a.anDerReihe == 3)
                {
                    a.Rathaus3++;
                }
                if (a.anDerReihe == 4)
                {
                    a.Rathaus4++;
                }
            }
        }
        if (gebäude == 2)
        {
            GUI.Label(new Rect(1050, 100, 550, 500), "Du hast eine Kaserne");
            GUI.Label(new Rect(1050, 115, 570, 500), "gewürfelt!");
            if (kaserne1 < 1)
            {
                kaserne1++;
                if (a.anDerReihe == 1)
                {
                    a.kasernen1++;
                }
                if (a.anDerReihe == 2)
                {
                    a.kasernen2++;
                }
                if (a.anDerReihe == 3)
                {
                    a.kasernen3++;
                }
                if (a.anDerReihe == 4)
                {
                    a.kasernen4++;
                }
            }

        }
        if (gebäude == 3)
        {
            GUI.Label(new Rect(1050, 100, 550, 500), "Du hast ein");
            GUI.Label(new Rect(1050, 115, 570, 500), "Brückengebäude gewürfelt!");
            if (brücke1 < 1)
            {
                brücke1++;
                if (a.anDerReihe == 1)
                {
                    a.brücken1++;
                }
                if (a.anDerReihe == 2)
                {
                    a.brücken2++;
                }
                if (a.anDerReihe == 3)
                {
                    a.brücken3++;
                }
                if (a.anDerReihe == 4)
                {
                    a.brücken4++;
                }
            }
        }
        if (gebäude == 4)
        {
            GUI.Label(new Rect(1050, 100, 550, 500), "Du hast eine Niete");
            GUI.Label(new Rect(1050, 115, 570, 500), "gewürfelt!");
            if (niete1 < 1)
            {
                niete1++;
                if (a.anDerReihe == 1)
                {
                    a.niete1++;
                }
                if (a.anDerReihe == 2)
                {
                    a.niete2++;
                }
                if (a.anDerReihe == 3)
                {
                    a.niete3++;
                }
                if (a.anDerReihe == 4)
                {
                    a.niete4++;
                }
            }
        }
        if (gebäude == 5)
        {
            GUI.Label(new Rect(1050, 100, 550, 500), "Du hast einen Werft");
            GUI.Label(new Rect(1050, 115, 570, 500), "gewürfelt!");
            if (hafen1 < 1)
            {
                hafen1++;
                if (a.anDerReihe == 1)
                {
                    a.hafen1++;
                }
                if (a.anDerReihe == 2)
                {
                    a.hafen1++;
                }
                if (a.anDerReihe == 3)
                {
                    a.hafen1++;
                }
                if (a.anDerReihe == 4)
                {
                    a.hafen1++;
                }
            }
        }
        if (zweimal == 3)
        {
            if (einmal1 == 0)
            {
                einmal1 = 1;
                kaserne1 = 0;
                rathaus1 = 0;
            }
        }
        if (bauen == 1)
        {
            if (darfnicht == 0)
            {
                if (zweimal == 3)
                {
                    Debug.Log("zweimalbauen");
                    butRect = new Rect((Screen.width - ctrlWidh) - 50, 0, ctrlWidh + 1, ctrlHight);
                    butRect.y = (Screen.height - ctrlHight) / 4 + 40;//+ 40
                    if (GUI.Button(butRect, "Würfeln"))
                    {
                        if (hatschon == 0)
                        {
                            //  würfeln = 1;
                            //	zweimal --;
                            darfnoch = 1;
                            hatschon = 1;
                        }
                        else
                        {
                            Debug.Log("hatschon");
                        }
                        if (hatschon == 0)
                        {
                            if (a.coints > 2)
                            {
                                if (a.stamm == 1)
                                {
                                    würfeln = 1;
                                    bauen = 1;
                                }
                            }
                            if (a.coints > 1)
                            {
                                if (a.stamm == 3)
                                {
                                    würfeln = 1;
                                    bauen = 1;
                                }
                            }
                        }

                    }
                }
                if (darfnoch == 0)
                {
                    if (a.stamm == 1)
                    {
                        if (a.coints > 2)
                        {
                            //if(zweimal == 0){
                            butRect.y = (Screen.height - ctrlHight) / 4 + 40;
                            if (GUI.Button(butRect, "Würfeln"))
                            {
                                würfeln = 1;
                                //	zweimal --;
                                darfnoch = 1;
                            }
                            //}else {würfeln = 1;
                            //	darfnoch = 1;
                            //}
                        }
                        else
                        {
                            if (zweimal == 0)
                            {
                                //würfeln = 1;
                                //	darfnoch = 1;
                            }
                        }
                    }
                }
            }
            if (a.coints > 2)
            {
                if (darfnoch == 0)
                {
                    if (a.stamm == 1)
                    {
                      //  darfnicht = 1;
                        butRect.y = (Screen.height - ctrlHight) / 4;
                        if (GUI.Button(butRect, "Mauer bauen für 3 Rubine"))
                        {
                            if (a.coints > 2)
                            {
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
                                mauer = 1;
                                darfnoch = 1;
                                a.coints -= 3;
                            }
                        }
                    }

                }
            }
            if (a.coints > 4)
            {
                if (darfnoch == 0)
                {
                    if (a.stamm == 1)
                    {
                        butRect.y = (Screen.height - ctrlHight) / 4 - 40;
                        if (GUI.Button(butRect, "Tor bauen für 3 Rubine"))
                        {
                            if (a.coints > 2)
                            {
                                if (a.anDerReihe == 1)
                                {
                                    a.rotCoints -= 5;
                                }
                                if (a.anDerReihe == 2)
                                {
                                    a.blauCionts -= 5;
                                }
                                if (a.anDerReihe == 3)
                                {
                                    a.grünCoints -= 5;
                                }
                                if (a.anDerReihe == 4)
                                {
                                    a.gelbCoints -= 5;
                                }
                                tor = 1;
                                darfnoch = 1;
                                a.coints -= 5;
                            }
                        }
                    }

                }
            } // int ZweimalBauenElf; //Flos geile ElfenF. 2x Geb. bauen
              ////////////////////FLOS ELFEN 2x Bauen SpezialF.

            if (a.coints > 2)
            {
                if (darfnoch == 0)
                {
                    if (a.stamm == 3)

                    {
                        if (gebäudenull == 0)
                        {
                            gebäude = 0;
                            butRect.y = (Screen.height - ctrlHight) / 4 + 40;
                            if (GUI.Button(butRect, "Würfeln"))
                            {
                                würfeln = 1;
                                gebäudenull = 1;
                            }
                            butRect.y = (Screen.height - ctrlHight) / 4;
                            if (GUI.Button(butRect, "Baue mit zwei Rubinen zwei Gebäude deiner Wahl"))
                            {
                                if (a.coints > 2)
                                {
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
                                    zweilmalbauen = 1;
                                    darfnoch = 1;
                                    a.coints -= 3;
                                    darfnicht = 1;
                                }
                            }
                        }

                    }
                }
            }

            /////////////Die SpezialFähigkeit 2x Bauen 
            if (zweilmalbauen == 1)
            {

                if (darfnoche == 0)
                {

                    if (a.anDerReihe == 1)
                    {
                        a.spez1++;
                        darfnoche = 1;
                    }
                    if (a.anDerReihe == 2)
                    {
                        a.spez2++;
                        darfnoche = 1;
                    }
                    if (a.anDerReihe == 3)
                    {
                        a.spez3++;
                        darfnoche = 1;
                    }
                    if (a.anDerReihe == 4)
                    {
                        a.spez4++;
                        darfnoche = 1;
                    }
                }
            }
        }
        if (Schleife1 < 2)
        {
            if (zweilmalbauen == 1)
            {
                //darfnicht = 1;
                butRect.y = (Screen.height - ctrlHight) / 4 - 20;
                if (GUI.Button(butRect, "Baue ein Rahthaus"))
                {
                    gebäude = 1;
                    Schleife1++;
                    bauen = 1;
                }
                butRect.y = (Screen.height - ctrlHight) / 4 + 10;
                if (GUI.Button(butRect, "Baue eine Kaserne"))
                {
                    gebäude = 2;
                    Schleife1++;
                    bauen = 1;
                }
                butRect.y = (Screen.height - ctrlHight) / 4 + 40;
                if (GUI.Button(butRect, "Baue ein Brückengebäude"))
                {
                    gebäude = 3;
                    Schleife1++;
                    bauen = 1;
                }
                if (a.map > 3)
                {
                    butRect.y = (Screen.height - ctrlHight) / 4 + 70;
                    if (GUI.Button(butRect, "Baue eine Werft"))
                    {
                        gebäude = 5;
                        Schleife1++;
                        bauen = 1;
                    }
                }
            }
        }
        else
        {
            zweilmalbauen = 0;
        }

        if (bauen == 1)
        {
            if (einmal == 0)
            {
                if (a.stamm == 1)
                {
                    if (a.coints < 3)
                    {
                        würfeln = 1;
                        einmal = 1;
                    }
                }
                else
                {
                    if (mauer == 0)
                    {
                        würfeln = 1;
                        einmal = 1;
                    }
                }
            }
        }
        if (bauenn == 1)
        {
            if (zweimal  == 2)//!!!!!!!!!!!!!!!!!!!!!! 2
            {
                if (darfnicht == 0)
                {
                    if (würfeln == 0)
                    {
                        Debug.Log("istda");
                        butRect = new Rect((Screen.width - ctrlWidh) - 50, 0, ctrlWidh + 1, ctrlHight);
                        butRect.y = (Screen.height - ctrlHight) / 4 + 40;
                        if (GUI.Button(butRect, "Würfeln"))
                        {
                            zweimal = 0;
                           // bauenn = 0;
                            bauen = 1;
                        }
                    }
                }
            }
        }
        if (bauen == 1) {
            if (mauer == 1)
            {
                if (darfnoche == 0)
                {
                    if (a.anDerReihe == 1)
                    {
                        a.spez1++;
                        darfnoche = 1;
                    }
                    if (a.anDerReihe == 2)
                    {
                        a.spez2++;
                        darfnoche = 1;
                    }
                    if (a.anDerReihe == 3)
                    {
                        a.spez3++;
                        darfnoche = 1;
                    }
                    if (a.anDerReihe == 4)
                    {
                        a.spez4++;
                        darfnoche = 1;
                    }
                }
                darfnicht = 1;
                butRect.y = (Screen.height - ctrlHight) / 4 - 20;
                if (GUI.Button(butRect, "Mauer oben"))
                {
                    wmauer = 1;
                    mauer = 0;
                }
                butRect.y = (Screen.height - ctrlHight) / 4 + 10;
                if (GUI.Button(butRect, "Mauer links"))
                {
                    wmauer = 2;
                    mauer = 0;
                }
                butRect.y = (Screen.height - ctrlHight) / 4 + 40;
                if (GUI.Button(butRect, "Mauer unten"))
                {
                    wmauer = 3;
                    mauer = 0;
                }
                butRect.y = (Screen.height - ctrlHight) / 4 + 70;
                if (GUI.Button(butRect, "Mauer rechts"))
                {
                    wmauer = 4;
                    mauer = 0;
                }
            }
            if (tor == 1)
            {
                if (darfnoche == 0)
                {
                    if (a.anDerReihe == 1)
                    {
                        a.spez1++;
                        darfnoche = 1;
                    }
                    if (a.anDerReihe == 2)
                    {
                        a.spez2++;
                        darfnoche = 1;
                    }
                    if (a.anDerReihe == 3)
                    {
                        a.spez3++;
                        darfnoche = 1;
                    }
                    if (a.anDerReihe == 4)
                    {
                        a.spez4++;
                        darfnoche = 1;
                    }
                }
                darfnicht = 1;
                butRect.y = (Screen.height - ctrlHight) / 4 - 20;
                if (GUI.Button(butRect, "Tor oben"))
                {
                    wtor = 1;
                    tor = 0;
                }
                butRect.y = (Screen.height - ctrlHight) / 4 + 10;
                if (GUI.Button(butRect, "Tor links"))
                {
                    wtor = 2;
                    tor = 0;
                }
                butRect.y = (Screen.height - ctrlHight) / 4 + 40;
                if (GUI.Button(butRect, "Tor unten"))
                {
                    wtor = 3;
                    tor = 0;
                }
                butRect.y = (Screen.height - ctrlHight) / 4 + 70;
                if (GUI.Button(butRect, "Tor rechts"))
                {
                    wtor = 4;
                    tor = 0;
                }
            }
        }
    }
	void Update () {
     
        //if(bauenn == 1)
        //{
         //   bauen = 1;
        //}
		if (a.spielvorbei == 1) {
			bauen = 0;
		}
		if (a.start == 1) {
			if (a.map == 1) {
			//	Vector3 temp = new Vector3 (179f, 450, 227);
			//	this.transform.position = temp;
			}
			if (a.map == 2) {
			//	Vector3 temp = new Vector3 (264f, 650, 117f);
			//	this.transform.position = temp;
			}
			if (a.map == 3) {
			//	Vector3 temp = new Vector3 (264f, 650, 117f);
			//	this.transform.position = temp;
			}
			if (a.map == 4) {
				//Vector3 temp = new Vector3 (264f, 650, 117f);
			//	this.transform.position = temp;
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
            if (bauen == 1) {
				if (würfeln == 1) {
					Debug.Log ("Du hast Bauen gewählt");
					if(a.map == 4){
					gebäude = Random.Range (1, 6);
					}else if(a.map != 4){
						gebäude = Random.Range (1, 5);
					}
					würfeln = 0;
				}
			}
			if (a.darfnochwasmachen == 1) {
				GetComponent<Renderer> ().enabled = true;
			} else {
				if (zweimal == 0) {
					GetComponent<Renderer> ().enabled = false;
				} else if (darfwürfeln == 0) {
					GetComponent<Renderer> ().enabled = false;
				}
			} 	

			if (a.f == 0) {
                bauenn = 0;
                Debug.Log ("f funktioniert");
				gebäude = 0;
				bauen = 0;
				darfwürfeln = 0;
				zweimal = 0;
				darfnoch = 0;
				hatschon = 0;
				darfnicht = 0;
				einmal = 0;
				kaserne1 = 0;
				einmal1 = 0;
				rathaus1 = 0;
				brücke1 = 0;
				niete1 = 0;
				darfnoche = 0;
                gebäudenull = 0;
                Schleife1 = 0;
                zweilmalbauen = 0;
                mauer = 0;
                tor = 0;
            }
			if (Input.GetKeyDown (KeyCode.F)) {
                bauenn = 0;
				gebäude = 0;
				bauen = 0;
				darfwürfeln = 0;
				zweimal = 0;
				darfnoch = 0;
				hatschon = 0;
				darfnicht = 0;
				einmal = 0;
				kaserne1 = 0;
				einmal1 = 0;
				rathaus1 = 0;
				brücke1 = 0;
				niete1 = 0;
				darfnoche = 0;
                gebäudenull = 0;
                Schleife1 = 0;
                zweilmalbauen = 0;
                mauer = 0;
                tor = 0;
            }
		}
	}
}

