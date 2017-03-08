using UnityEngine;

using System.Collections;
//
//zufall bei rassen
//map 2 die unterste reihe ist unsichtbar
//man kann häfen außer reichweite ansteuern und auch länder außer reichweite angreifen
//wenn man von hafen zu hafen in einem zug fährt hat der ursprugshafen nicht ein schiff weniger
//schiffe können auch ohne die gleiche farbe zu haben in den hafen fahren
//wenn d1 verloren hat, setzt er ein wert auf 11 (hab ich schon verbessert aber vllt folgefehler)
//beschreibungen von angriff und verschiebung sind zu weit links
//wenn man schiffe ausbildet und dann nochmal aufs land klickt kann man unendlic hviele schiffe ausbilden
//schiffe sind iwie verbugt: ich habe einmal nicht bewegt und amn kann nur nich auserhalb des radius klicken danit dass schiff dahin geht
public class Rotistdran : MonoBehaviour {
    int einmala;
    int einmalb;
    public int anDerReihe;
	public int darfnochwasmachen = 1;
	public GameObject AngriffVerschiebung;
	public GameObject wieVieleSpieler;
	private wieVieleSpielerS a;
	public int länderRot = 1;
	public int länderBlau = 1;
	public int länderGelb;
	public int länderGrün;
	public int rotlebt = 1;
	public int blaulebt = 1;
	public int grünlebt;
	public int gelblebt;
	public int rotCoints;
	public int blauCionts;
	public int grünCoints;
	public int gelbCoints;
	public int coints;
	public int f;
	public int map;
	public int start;
	int einmal;
	public int startbutton;
	public int sternlandan = 1;
	float ctrlWidh = 160;
	float ctrlHight = 30;
	Rect butRect;
	public GameObject MainCamera;
	private pauseMenu b;
    private camaraBewegt c;
    public int stamm;
	public int stamm1;
	public int stamm2;
	public int stamm3;
	public int stamm4;
	public string st1;
	public string st2;
	public string st3;
	public string st4;
	public GameObject Ausbilden;
	private tAusbilden g;
	public int andermap;
	public string username1 = "Name";
	public string username2 = "Name";
	public string username3 = "Name";
	public string username4 = "Name";
	public string score1;
	public string score2;
	public string score3;
	public string score4;
	public int rangliste;

	public float Rathaus1;
	public float Rathaus2;
	public float Rathaus3;
	public float Rathaus4;

	public float kasernen1;
	public float kasernen2;
	public float kasernen3;
	public float kasernen4;

	public float brücken1;
	public float brücken2;
	public float brücken3;
	public float brücken4;

	public float niete1;
	public float niete2;
	public float niete3;
	public float niete4;

	public int hafen1;
	public int hafen2;
	public int hafen3;
	public int hafen5;

	public int truppen1;
	public int truppen2;
	public int truppen3;
	public int truppen4;

	public int truppenz1;
	public int truppenz2;
	public int truppenz3;
	public int truppenz4;

	public int Länder1;
	public int Länder2;
	public int Länder3;
	public int Länder4;

	public int spez1;
	public int spez2;
	public int spez3;
	public int spez4;

	public int spielvorbei;

	public int statistik;
	public int zweirubine;
	public int rubinlandan;

	public int getland;
	public int getfarbe;
	public int hafen;
	public int los;
	public int schiffe;
	public int schiffok;
	public Vector3 p;
	public int schiffeverschiebung;
    public Vector3 pa;
    public Vector3 pk;
    public int kameramove;
    public int schifftruppen;
    public int hafenminusschiff;
    public int schiffistda;
    public int schiffland;
    public int angreifen;
    public int schiffangriff;
    public int landerobert;
    public int loshafen;

    //Land: mD11 Nummer: -411 also - für bustabe munis
    //Land: Dm11 Nummer: 4110 also - für minus 11 und 0 dafür dass die zahl munus ist und nicht der bustabe
    void OnGUI(){
		if (einmal == 1) {
			if (spielvorbei == 0) {
				GUI.Label (new Rect (1200, 10, 500, 500), "Rubine: " + coints);
                if (map > 3)
                {
                    GUI.Label(new Rect(1200, 50, 500, 500), "Truppen: " + schifftruppen);
                }
            }
		} else if (anDerReihe == 2) {
			einmal = 1;
		}
		if (start == 0) {
			if (b.ispause == false) {
				//Debug.Log ("start = 0");
				butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
				butRect.y = 60;
				if (GUI.Button (butRect, "Start")) {
					startbutton = 1;
					Debug.Log ("gedrückt");
				}
				butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
				butRect.y += 30;
				if (GUI.Button (butRect, "nächste map")) {

					if (map == 1) {
						if (a.spieler == 3) {
							if (andermap == 0) {
								andermap = 1;
							} else {
								map ++;
								andermap = 0;
							}
						} else {
							map ++;
						}
					} else {
						map ++;
					}
				}
				butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 100, 0, ctrlWidh, ctrlHight);
				butRect.y = 100;
				if (GUI.Button (butRect, "Rubine = " + b.setzteRubine)) {
					b.setzteRubine += 3;
					if (b.setzteRubine == 18) {
						b.setzteRubine = 100;
					}
					if (b.setzteRubine == 103) {
						b.setzteRubine = 0;
					}
					rotCoints = b.setzteRubine;
					blauCionts = b.setzteRubine;
					grünCoints = b.setzteRubine;
					gelbCoints = b.setzteRubine;

				}
				butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 100, 0, ctrlWidh, ctrlHight);
				butRect.y = 100;
				if (GUI.Button (butRect, "Spieler 1: " + st1)) {
					stamm1 ++;
					if (stamm1 == 5) {
						stamm1 = 1;
					}
				}
				butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 100, 0, 150, 20);
				butRect.y = 130;
				username1 = GUI.TextField (butRect, username1);


				butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 100, 0, ctrlWidh, ctrlHight);
				butRect.y = 160;
				if (GUI.Button (butRect, "Spieler 2: " + st2)) {
					stamm2 ++;
					if (stamm2 == 5) {
						stamm2 = 1;
					}
				}
				butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 100, 0, 150, 20);
				butRect.y = 190;
				username2 = GUI.TextField (butRect, username2);
				if (a.spieler > 2) {
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 100, 0, ctrlWidh, ctrlHight);
					butRect.y = 220;
					if (GUI.Button (butRect, "Spieler 3: " + st3)) {
						stamm3 ++;
						if (stamm3 == 5) {
							stamm3 = 1;
						}
					}
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 100, 0, 150, 20);
					butRect.y = 250;
					username3 = GUI.TextField (butRect, username3);

				}
				if (a.spieler == 4) {
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 100, 0, ctrlWidh, ctrlHight);
					butRect.y = 280;
					if (GUI.Button (butRect, "Spieler 4: " + st4)) {
						stamm4 ++;
						if (stamm4 == 5) {
							stamm4 = 1;
						}
					}
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 100, 0, 150, 20);
					butRect.y = 310;
					username4 = GUI.TextField (butRect, username4);

				}
		
				butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 100, 0, ctrlWidh, ctrlHight);
				butRect.y += 140;
				if (GUI.Button (butRect, "Super-Stern-Land * " + g.superstern)) {
					g.superstern++;
					if (g.superstern == 4) {
						g.superstern = 1;
					}
				}
				if (map == 1) {
					if (andermap == 0) {
						butRect.y += 40;
						if (GUI.Button (butRect, "Super-Stern-Land T: " + g.tC3)) {
							if (map == 1) {
								g.tC3 += 1;
							}
						}
					}
				}
				if (andermap == 1) {
					butRect.y += 40;
					if (GUI.Button (butRect, "Super-Stern-Land T: " + g.tA3)) {
						if (andermap == 1) {
							g.tA3 += 1;
						}
					}
				}
				if (map == 3) {
					butRect.y += 40;
					if (GUI.Button (butRect, "Super-Stern-Land T: " + g.tD4)) {
						g.tD4 += 1;
					}
				}
				if (map == 1) {
					butRect.y += 40;
					if (andermap == 0) {
						if (GUI.Button (butRect, "Stern-Land T: " + g.tA3)) {
							g.tA3 += 1;
							g.tE3 += 1;
						}
					}
				}
				if (map == 3) {
					butRect.y += 40;
					if (GUI.Button (butRect, "Stern-Land T: " + g.tD1)) {
						g.tD1 += 1;
						g.tD7 += 1;
					}
				}
				if (sternlandan == 1) {
					butRect.y += 40;
					if (GUI.Button (butRect, "Sternland An")) {
						sternlandan = 0;
					}
				} else if (sternlandan == 0) {
					butRect.y += 40;
					if (GUI.Button (butRect, "Sternland Aus")) {
						sternlandan = 1;
					}
				}
				if (rubinlandan == 1) {
					butRect.y += 40;
					if (GUI.Button (butRect, "Rubinland An")) {
						rubinlandan = 0;
					}
				} else if (rubinlandan == 0) {
					butRect.y += 40;
					if (GUI.Button (butRect, "Rubinland Aus")) {
						rubinlandan = 1;
					}
				}
		
			}
		}
		if (start == 1) {
			if (anDerReihe == 1) {
				GUI.Label (new Rect (200, 70, 500, 500), "(" + username1 + ")");
			}
			if (anDerReihe == 2) {
				GUI.Label (new Rect(200, 70, 500, 500), "(" + username2 + ")");
			}
			if (anDerReihe == 3) {
				GUI.Label (new Rect (200, 70, 500, 500), "(" + username3 + ")");
			}
			if (anDerReihe == 4) {
				GUI.Label (new Rect (200, 70, 500, 500), "(" + username4 + ")");
			}
		}
	}
	
	
	// Use this for initialization
	void Start () {
		stamm1 = 1;
		stamm2 = 1;
		stamm3 = 1;
		stamm4 = 1;
		gameObject.GetComponent<Renderer>().material.color = Color.red;
		a =wieVieleSpieler.GetComponent<wieVieleSpielerS> ();
        b = MainCamera.GetComponent<pauseMenu>();
        c = MainCamera.GetComponent<camaraBewegt>();
        länderRot = 1;
		länderBlau = 1;
		map = 1;
		butRect = new Rect ((Screen.width - ctrlWidh)/2,0,ctrlWidh,ctrlHight);
		start = -1;
		GetComponent<Renderer> ().enabled = false;
		g = Ausbilden.GetComponent<tAusbilden> ();
		rubinlandan = 1;
		p = new Vector3 (100, 100000, 1000);
        pa = new Vector3(100, 100000, 1000);

    }
	
	// Update is called once per frame
	void Update () {
        if(angreifen == 1)
        {
            Debug.Log("angreifen = 1");
        }
        if(kameramove == 1)
        {
            c.hatsichbewegt = 2;
        }
		if (stamm1 == 1) {
			st1 = "Mensch";
		}
		if (stamm1 == 2) {
			st1 = "Untote";
		}
		if (stamm1 == 3) {
			st1 = "Elf";
		}
		if (stamm1 == 4) {
			st1 = "Ork";
		}
		if (stamm2 == 1) {
			st2 = "Mensch";
		}
		if (stamm2 == 2) {
			st2 = "Untote";
		}
		if (stamm2 == 3) {
			st2 = "Elf";
		}
		if (stamm2 == 4) {
			st2 = "Ork";
		}
		if (stamm3 == 1) {
			st3 = "Mensch";
		}
		if (stamm3 == 2) {
			st3 = "Untote";
		}
		if (stamm3 == 3) {
			st3 = "Elf";
		}
		if (stamm3 == 4) {
			st3 = "Ork";
		}
		if (stamm4 == 1) {
			st4 = "Mensch";
		}
		if (stamm4 == 2) {
			st4 = "Untote";
		}
		if (stamm4 == 3) {
			st4 = "Elf";
		}
		if (stamm4 == 4) {
			st4 = "Ork";
		}

		if (start == 1) {
            if (darfnochwasmachen == 0)
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

            if (f == 0) {
                loshafen = 0;
                if (anDerReihe == 1) {
					anDerReihe = 2;
				} else if (anDerReihe == 2) {
					if (a.spieler > 2) {
						anDerReihe = 3;
					} else
						anDerReihe = 1;
				} else if (anDerReihe == 3) {
					if (a.spieler == 4) {
						anDerReihe = 4;
					} else
						anDerReihe = 1;
				} else if (anDerReihe == 4) {
					anDerReihe = 1;
				}
			}
			if (Input.GetKeyDown (KeyCode.F)) {
                loshafen = 0;
				if (anDerReihe == 1) {
					anDerReihe = 2;
				} else if (anDerReihe == 2) {
					if (a.spieler > 2) {
						anDerReihe = 3;
					} else
						anDerReihe = 1;
				} else if (anDerReihe == 3) {
					if (a.spieler == 4) {
						anDerReihe = 4;
					} else
						anDerReihe = 1;
				} else if (anDerReihe == 4) {
					anDerReihe = 1;
				}
			}
			if (anDerReihe == 1) {
				coints = rotCoints;
				stamm = stamm1;
				if (länderRot == 0) {
					anDerReihe = 2;
				}
			}
			if (anDerReihe == 2) {
				stamm = stamm2;
				coints = blauCionts;
				if (länderBlau == 0) {
					anDerReihe = 3;
				}
			}
			if (anDerReihe == 3) {
				stamm = stamm3;
				coints = grünCoints;
				if (länderGrün == 0) {
					anDerReihe = 4;
				}
			}
			if (anDerReihe == 4) {
				stamm= stamm4;
				coints = gelbCoints;
				if (länderGelb == 0) {
					gelblebt = 0;
					anDerReihe = 1;
				}
			}

			if (f == 0) {
                landerobert = 0;
                schiffangriff = 0;
                angreifen = 0;
                p = new Vector3(100, 100000, 1000);
                pa = new Vector3(100, 100000, 1000);
                zweirubine = 0;
				getland = 0;
				schiffeverschiebung = 0;
                schiffe = 0;
                if (anDerReihe == 1) {
                    GetComponent<Renderer> ().enabled = true;
					darfnochwasmachen = 1;
					Debug.Log ("rotistsichtbar");
				} else {
					GetComponent<Renderer> ().enabled = false;
					darfnochwasmachen = 1;
					Debug.Log ("darfnochwasmachen = 1");
				}
			}
			if (Input.GetKeyDown (KeyCode.F)) {
                landerobert = 0;
                schiffangriff = 0;
                angreifen = 0;
				getland = 0;
				zweirubine = 0;
				schiffeverschiebung = 0;
                schiffe = 0;
				if (anDerReihe == 1) {
					p = new Vector3 (100, 100000, 1000);
                    pa = new Vector3(100, 100000, 1000);
                    GetComponent<Renderer> ().enabled = true;
					darfnochwasmachen = 1;
					Debug.Log ("rotistsichtbar");
				} else {
					GetComponent<Renderer> ().enabled = false;
					darfnochwasmachen = 1;
					Debug.Log ("darfnochwasmachen = 1");
				}
			}
		
		}

		if (anDerReihe != 1) {
			GetComponent<Renderer> ().enabled = false;
		}

			if (startbutton == 0) {
			if (a.spieler != 0) {
				start = 0;
			}
		} else {
			start = 1;
			//Debug.Log ("start = 1");
		}

		if (map == 5) {
			map = 1;
		}
		if (start == 1) {
			if(andermap == 1){
				sternlandan = 0;
			}
		}
		if (username1 == "") {
			username1 = "Name";
		}
		if (username2 == "") {
			username2 = "Name";
		}
		if (username3 == "") {
			username3 = "Name";
		}
		if (username4 == "") {
			username4 = "Name";
		}
        if(schiffe > 4)
        {
            schiffe = 5;
        }
}
}


