using UnityEngine;
using System.Collections;

public class pauseMenu : MonoBehaviour {
	public bool ispause = false;
	Rect butRect;
	float ctrlWidh = 160;
	float ctrlHight = 30;
	public int optionen;
	public int setzteRubine;
	public GameObject RotDran;
	private Rotistdran a;
	int truppenVerändern;
	int a1;
	int b;
	int c;
	int d;
	int e;
	int fi;
	int g;
	int h;
	int sternland;
	public GameObject Ausbilden;
	private tAusbilden f;
	int einmal;
	int musik;
		public int levelIndex;
	public int aufgeben;
	public GameObject wieVieleSpieler;
	private wieVieleSpielerS be;
	int hauptmenu;
	//SceneFader sceneFader;
	// Use this for initialization
	void Awake () {
		be = wieVieleSpieler.GetComponent<wieVieleSpielerS> ();
		butRect = new Rect ((Screen.width - ctrlWidh)/2,0,ctrlWidh,ctrlHight);
		a = RotDran.GetComponent<Rotistdran> ();
		f = Ausbilden.GetComponent<tAusbilden> ();
		f.superstern = 2;
		AudioListener.volume = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (f.tA1 < 0) {
			f.tA1 = 0;
		}
		if (f.tA2 < 0) {
			f.tA2 = 0;
		}
		if (f.tA3 < 0) {
			f.tA3 = 0;
		}
		if (f.tA4 < 0) {
			f.tA4 = 0;
		}
		if (f.tA5 < 0) {
			f.tA5 = 0;
		}
		if (f.tA6 < 0) {
			f.tA6 = 0;
		}
		if (f.tA7 < 0) {
			f.tA7 = 0;
		}
		if (f.tA8 < 0) {
			f.tA8 = 0;
		}
		if (f.tB1 < 0) {
			f.tB1 = 0;
		}
		if (f.tB2 < 0) {
			f.tB2 = 0;
		}
		if (f.tB3 < 0) {
			f.tB3 = 0;
		}
		if (f.tB4 < 0) {
			f.tB4 = 0;
		}
		if (f.tB5 < 0) {
			f.tB5 = 0;
		}
		if (f.tB6 < 0) {
			f.tB6 = 0;
		}
		if (f.tB7 < 0) {
			f.tB7 = 0;
		}
		if (f.tB8 < 0) {
			f.tB8 = 0;
		}
		if (f.tC1 < 0) {
			f.tC1 = 0;
		}
		if (f.tC2 < 0) {
			f.tC2 = 0;
		}
		if (f.tC3 < 0) {
			f.tC3 = 0;
		}
		if (f.tC4 < 0) {
			f.tC4 = 0;
		}
		if (f.tC5 < 0) {
			f.tC5 = 0;
		}
		if (f.tC6 < 0) {
			f.tC6 = 0;
		}
		if (f.tC7 < 0) {
			f.tC7 = 0;
		}
		if (f.tC8 < 0) {
			f.tC8 = 0;
		}
		if (f.tD1 < 0) {
			f.tD1 = 0;
		}
		if (f.tD2 < 0) {
			f.tD2 = 0;
		}
		if (f.tD3 < 0) {
			f.tD3 = 0;
		}
		if (f.tD4 < 0) {
			f.tD4 = 0;
		}
		if (f.tD5 < 0) {
			f.tD5 = 0;
		}
		if (f.tD6 < 0) {
			f.tD6 = 0;
		}
		if (f.tD7 < 0) {
			f.tD7 = 0;
		}
		if (f.tD8 < 0) {
			f.tD8 = 0;
		}
		if (f.tE1 < 0) {
			f.tE1 = 0;
		}
		if (f.tE2 < 0) {
			f.tE2 = 0;
		}
		if (f.tE3 < 0) {
			f.tE3 = 0;
		}
		if (f.tE4 < 0) {
			f.tE4 = 0;
		}
		if (f.tE5 < 0) {
			f.tE5 = 0;
		}
		if (f.tE6 < 0) {
			f.tE6 = 0;
		}
		if (f.tE7 < 0) {
			f.tE7 = 0;
		}
		if (f.tE8 < 0) {
			f.tE8 = 0;
		}
		if (f.tF1 < 0) {
			f.tF1 = 0;
		}
		if (f.tF2 < 0) {
			f.tF2 = 0;
		}
		if (f.tF3 < 0) {
			f.tF3 = 0;
		}
		if (f.tF4 < 0) {
			f.tF4 = 0;
		}
		if (f.tF5 < 0) {
			f.tF5 = 0;
		}
		if (f.tF6 < 0) {
			f.tF6 = 0;
		}
		if (f.tF7 < 0) {
			f.tF7 = 0;
		}
		if (f.tF8 < 0) {
			f.tF8 = 0;
		}
		if (f.tG1 < 0) {
			f.tG1 = 0;
		}
		if (f.tG2 < 0) {
			f.tG2 = 0;
		}
		if (f.tG3 < 0) {
			f.tG3 = 0;
		}
		if (f.tG4 < 0) {
			f.tG4 = 0;
		}
		if (f.tG5 < 0) {
			f.tG5 = 0;
		}
		if (f.tG6 < 0) {
			f.tG6 = 0;
		}
		if (f.tG7 < 0) {
			f.tG7 = 0;
		}
		if (f.tG8 < 0) {
			f.tG8 = 0;
		}
		if (f.tH1 < 0) {
			f.tH1 = 0;
		}
		if (f.tH2 < 0) {
			f.tH2 = 0;
		}
		if (f.tH3 < 0) {
			f.tH3 = 0;
		}
		if (f.tH4 < 0) {
			f.tH4 = 0;
		}
		if (f.tH5 < 0) {
			f.tH5 = 0;
		}
		if (f.tH6 < 0) {
			f.tH6 = 0;
		}
		if (f.tH7 < 0) {
			f.tH7 = 0;
		}
		if (f.tH8 < 0) {
			f.tH8 = 0;
		}
		//Application.LoadLevel (levelIndex);
		if (Input.GetKeyDown (KeyCode.Escape)) {
			ToggleTimeScale ();
			butRect = new Rect ((Screen.width - ctrlWidh)/2,0,ctrlWidh,ctrlHight);
			truppenVerändern = 0;
			setzteRubine = 0;
			a1 = 0;
			b = 0;
			c = 0;
			d = 0;
			e = 0;
			sternland = 0;
		}
		if (a.anDerReihe == 2) {
			if(einmal == 0){
				musik = 1;
				einmal = 1;
			}
		}
		if (musik == 1) {
			AudioListener.volume = 1;
		}else 
			AudioListener.volume = 0;
	}

	void OnGUI(){
		butRect = new Rect (0, 0, 50, ctrlHight);
		if (GUI.Button (butRect, "Esc")) {
			ToggleTimeScale ();
			butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
			truppenVerändern = 0;
			a1 = 0;
			b = 0;
			c = 0;
			d = 0;
			e = 0;
			sternland = 0;
			optionen = 0;
		}
		if (hauptmenu == 1) {
			if (GUI.Button  (new Rect ((Screen.width - ctrlWidh) / 2 - 40, (Screen.height - ctrlHight) / 2 - 50, ctrlWidh + 80, ctrlHight ), "Möchtest du wirklich zum Hauptmenü?")){

			}
			butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight );
			butRect.y = (Screen.height - ctrlHight) / 2 ;
			
			if (GUI.Button (butRect, "Ja")) {
				Application.LoadLevel (1);
			}
			butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
			butRect.y = (Screen.height - ctrlHight) / 2 + 50;
			
			if (GUI.Button (butRect, "Nein")) {
				optionen = 0;
				hauptmenu = 0;
			}
		}
		butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
		if (ispause) {
			if (optionen == 0) {
				butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
				butRect.y = (Screen.height - ctrlHight) / 2 - 80;

				if (GUI.Button (butRect, "Weiter")) {
					ToggleTimeScale ();
				}
				butRect.y = (Screen.height - ctrlHight) / 2 - 30;
				if (musik == 1) {
					if (GUI.Button (butRect, "Musik an")) {
						musik = 0;
					}
				} else
				if (GUI.Button (butRect, "Musik aus")) {
					musik = 1;
				}
				butRect.y += ctrlHight + 20;
				if (GUI.Button (butRect, "Optionen")) {
					optionen = 1;
					setzteRubine = 0;
				}
				butRect.y += ctrlHight + 20;
				if (GUI.Button (butRect, "Hauptmenu")) {
					if(a.start == 1){
					hauptmenu = 1;
					optionen = -1;
					}else {
						Application.LoadLevel (1);
					}
				}
				butRect.y += ctrlHight + 20;
				if (GUI.Button (butRect, "Spiel Schlie" + (char)223 + "en")) {
					Application.Quit ();
				}
			} else 
			if (a.start == 1) {
				if (optionen == 1) {
					if (truppenVerändern == 0) {
						butRect.y = (Screen.height - ctrlHight) / 2 - 80;
						if (GUI.Button (butRect, "Zurück")) {
							Debug.Log ("zürück");
							optionen = 0;
							a.rotCoints += setzteRubine;
							a.blauCionts += setzteRubine;
							a.grünCoints += setzteRubine;
							a.gelbCoints += setzteRubine;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 - 30 ;
						if (GUI.Button (butRect, "Rubine = " + setzteRubine)) {
							setzteRubine += 3;
							if (setzteRubine == 18) {
								setzteRubine = 100;
							}
							if (setzteRubine == 103) {
								setzteRubine = 0;
							}
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 20;
						if (GUI.Button (butRect, "Truppen verändern")) {
							truppenVerändern = 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 70;
						if (GUI.Button (butRect, "Extras")) {
							sternland = 1;
							optionen = 2;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 120;
						if (GUI.Button (butRect, "Aufgeben")) {
							aufgeben = 1;
							optionen = 2;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "Statistik")) {
							a.statistik = 1;
							optionen = 0;
						}
					}
				}
				if(aufgeben == 1){
						butRect.y += (Screen.height - ctrlHight) / 2 - 50;
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 130, 0, ctrlWidh, ctrlHight);
					if(a.rotlebt == 1){
						butRect.y += 50;
					if (GUI.Button (butRect, a.username1 +  " hat gewonnen")) {
							ToggleTimeScale();
							a.länderBlau = 0;
							if(be.spieler > 2){
								a.länderGrün = 0;
							}
							if(be.spieler == 4){
							a.länderGelb = 0;
								a.gelblebt = 0;
							}
				}
					}
					if(a.blaulebt == 1){
						butRect.y += 50;
						if (GUI.Button (butRect, a.username2 +  " hat gewonnen")) {
							ToggleTimeScale();
							a.länderRot = 0;
							if(be.spieler > 2){
							a.länderGrün = 0;
							}
							if(be.spieler == 4){
							a.länderGelb = 0;
								//a.gelblebt = 0;
							}
						}
					}
					if(be.spieler > 2){
						if(a.grünlebt == 1){
						butRect.y += 50;
						if (GUI.Button (butRect, a.username3 +  " hat gewonnen")) {
							ToggleTimeScale();
							a.länderRot = 0;
							a.länderBlau = 0;
								if(be.spieler == 4){
							a.länderGelb = 0;
							//		a.gelblebt = 0;
								}
						}
						}
					}
					if(be.spieler == 4){
						if(a.gelblebt == 1){
							butRect.y += 50;
							if (GUI.Button (butRect, a.username4 +  " hat gewonnen")) {
								ToggleTimeScale();
								a.länderRot = 0;
								a.länderBlau = 0;
								a.länderGrün = 0;
							}
						}
					}
				}
				if (sternland == 1) {
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 130, 0, ctrlWidh, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 + 70;
					if (GUI.Button (butRect, "Super-Stern-Land * " + f.superstern)) {
						f.superstern++;
						if (f.superstern == 4) {
							f.superstern = 1;
						}
					}
				
					butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 50;
					if (GUI.Button (butRect, "Zurück")) {
						sternland = 0;
						optionen = 0;
					}
					if (a.map == 1) {
						if (a.andermap == 0) {
							butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 130, 0, ctrlWidh, ctrlHight);
							butRect.y = (Screen.height - ctrlHight) / 2 - 10;
							if (GUI.Button (butRect, "Super-Stern-Land T: " + f.tC3)) {
								if (a.map == 1) {
									f.tC3 += 1;
								}
							}
						}
					}
					if (a.andermap == 1) {
						butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 130, 0, ctrlWidh, ctrlHight);
						butRect.y = (Screen.height - ctrlHight) / 2 - 10;
						if (GUI.Button (butRect, "Super-Stern-Land T: " + f.tA3)) {
							if (a.andermap == 1) {
								f.tA3 += 1;
							}
						}
					}
					if (a.map == 3) {
						butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 130, 0, ctrlWidh, ctrlHight);
						butRect.y = (Screen.height - ctrlHight) / 2 - 10;
						if (GUI.Button (butRect, "Super-Stern-Land T: " + f.tD4)) {
							if (a.map == 3) {
								f.tD4 += 1;
							}
						}
					}
					if (a.map == 1) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 30;
						if (a.andermap == 0) {
							if (GUI.Button (butRect, "Stern-Land T: " + f.tA3)) {
								if (a.map == 3) {
									f.tD1 += 1;
									f.tD7 += 1;
								}
							
							}
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 30;
						if (GUI.Button (butRect, "Stern-Land T: " + f.tD1)) {
							if (a.map == 3) {
								f.tD1 += 1;
								f.tD7 += 1;
							}
							
						}
					}
				
					if (a.sternlandan == 1) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 110;
						if (GUI.Button (butRect, "Sternland An")) {
							a.sternlandan = 0;
						}
					} else if (a.sternlandan == 0) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 110;
						if (GUI.Button (butRect, "Sternland Aus")) {
							a.sternlandan = 1;
						}
					}
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 100, 0, ctrlWidh, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 10;
					if (GUI.Button (butRect, "Rubine rot: " + a.rotCoints)) {
						a.rotCoints ++;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 30;
					if (GUI.Button (butRect, "Rubine blau: " + a.blauCionts)) {
						a.blauCionts ++;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 70;
					if (GUI.Button (butRect, "Rubine grün: " + a.grünCoints)) {
						a.grünCoints ++;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 110;
					if (GUI.Button (butRect, "Rubine gelb: " + a.gelbCoints)) {
						a.gelbCoints ++;
					}
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 90, 0, 30, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 + 30;
					if (GUI.Button (butRect, "-")) {
						if (a.map == 1) {
							f.tA3 -= 1;
							f.tE3 -= 1;
						}
						if (a.map == 3) {
							f.tD1 -= 1;
							f.tD7 -= 1;
						}
					}
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 90, 0, 30, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 10;
					if (GUI.Button (butRect, "-")) {
						if (a.map == 1) {
							f.tC3 -= 1;
						}
						if (a.andermap == 1) {
							f.tA3 -= 1;
						}
						if (a.map == 3) {
							f.tD4 -= 1;
						}
					}
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 140, 0, 30, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 10;
					if (GUI.Button (butRect, "-")) {
						a.rotCoints --;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 30;
					if (GUI.Button (butRect, "-")) {
						a.blauCionts --;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 70;
					if (GUI.Button (butRect, "-")) {
						a.grünCoints --;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 110;
					if (GUI.Button (butRect, "-")) {
						a.gelbCoints --;
					}
				}
				if (truppenVerändern == 1) {
					butRect.y = (Screen.height - ctrlHight) / 2 - 150;
					if (GUI.Button (butRect, "Zurück")) {
						truppenVerändern = 0;
						optionen = 0;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "A")) {
						truppenVerändern = 0;
						a1 = 1;
						optionen = 2;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "B")) {
						truppenVerändern = 0;
						b = 1;
						optionen = 2;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "C")) {
						truppenVerändern = 0;
						c = 1;
						optionen = 2;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "D")) {
						truppenVerändern = 0;
						d = 1;
						optionen = 2;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "E")) {
						truppenVerändern = 0;
						e = 1;
						optionen = 2;
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "F")) {
							truppenVerändern = 0;
							fi = 1;
							optionen = 2;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "G")) {
							truppenVerändern = 0;
							g = 1;
							optionen = 2;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "H")) {
							truppenVerändern = 0;
							h = 1;
							optionen = 2;
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "F")) {
							truppenVerändern = 0;
							fi = 1;
							optionen = 2;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "G")) {
							truppenVerändern = 0;
							g = 1;
							optionen = 2;
						}
					}
				}
				if (a1 == 1) {
					butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 150;
					if (GUI.Button (butRect, "Zurück")) {
						truppenVerändern = 0;
						optionen = 0;
						a1 = 0;
					}
					
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "Truppen A1: " + f.tA1)) {
						f.tA1 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "Truppen A2: " + f.tA2)) {
						f.tA2 += 1;
					}
					if (a.map != 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "Truppen A3: " + f.tA3)) {
						f.tA3 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "Truppen A4: " + f.tA4)) {
						f.tA4 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "Truppen A5: " + f.tA5)) {
						f.tA5 += 1;
					}
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen A6: " + f.tA6)) {
							f.tA6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen A7: " + f.tA7)) {
							f.tA7 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "Truppen A8: " + f.tA8)) {
							f.tA8 += 1;
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen A6: " + f.tA6)) {
							f.tA6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen A7: " + f.tA7)) {
							f.tA7 += 1;
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen A6: " + f.tA6)) {
							f.tA6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen A7: " + f.tA7)) {
							f.tA7 += 1;
						}
					}

					butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 40, 0, 30, ctrlHight);

					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "-")) {
						f.tA1 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "-")) {
						f.tA2 -= 1;
					}
					if (a.map != 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "-")) {
						f.tA3 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "-")) {
						f.tA4 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "-")) {
						f.tA5 -= 1;
					}
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tA6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tA7 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "-")) {
							f.tA8 -= 1;
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tA6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tA7 -= 1;
						}
					}
				}
				if (b == 1) {
					butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 150;
					if (GUI.Button (butRect, "Zurück")) {
						truppenVerändern = 0;
						optionen = 0;
						b = 0;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "Truppen B1: " + f.tB1)) {
						f.tB1 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "Truppen B2: " + f.tB2)) {
						f.tB2 += 1;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "Truppen B3: " + f.tB3)) {
						f.tB3 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "Truppen B4: " + f.tB4)) {
						f.tB4 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "Truppen B5: " + f.tB5)) {
						f.tB5 += 1;
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen B6: " + f.tB6)) {
							f.tB6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen B7: " + f.tB7)) {
							f.tB7 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "Truppen B8: " + f.tB8)) {
							f.tB8 += 1;
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen B6: " + f.tB6)) {
							f.tB6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen B7: " + f.tB7)) {
							f.tB7 += 1;
						}
					}

					butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 40, 0, 30, ctrlHight);
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "-")) {
						f.tB1 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "-")) {
						f.tB2 -= 1;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "-")) {
						f.tB3 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "-")) {
						f.tB4 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "-")) {
						f.tB5 -= 1;
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tB6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tB7 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "-")) {
							f.tB8 -= 1;
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tB6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tB7 -= 1;
						}
					}
				}
				if (c == 1) {
					butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 150;
					if (GUI.Button (butRect, "Zurück")) {
						truppenVerändern = 0;
						optionen = 0;
						c = 0;
					}
					if (a.map != 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "Truppen C1: " + f.tC1)) {
						f.tC1 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "Truppen C2: " + f.tC2)) {
						f.tC2 += 1;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "Truppen C3: " + f.tC3)) {
						f.tC3 += 1;
					}
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "Truppen C4: " + f.tC4)) {
						f.tC4 += 1;
					}if (a.map != 3) {

					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "Truppen C5: " + f.tC5)) {
						f.tC5 += 1;
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen C6: " + f.tC6)) {
							f.tC6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen C7: " + f.tC7)) {
							f.tC7 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "Truppen C8: " + f.tC8)) {
							f.tC8 += 1;
						}
					}
					}
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 40, 0, 30, ctrlHight);
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (a.map != 3) {
					if (GUI.Button (butRect, "-")) {
						f.tC1 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "-")) {
						f.tC2 -= 1;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "-")) {
						f.tC3 -= 1;
					}
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "-")) {
						f.tC4 -= 1;
					}
					if (a.map != 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "-")) {
						f.tC5 -= 1;
					}
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tC6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tC7 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "-")) {
							f.tC8 -= 1;
						}
					}
				}
				if (d == 1) {
					butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 150;
					if (GUI.Button (butRect, "Zurück")) {
						truppenVerändern = 0;
						optionen = 0;
						d = 0;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "Truppen D1: " + f.tD1)) {
						f.tD1 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "Truppen D2: " + f.tD2)) {
						f.tD2 += 1;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "Truppen D3: " + f.tD3)) {
						f.tD3 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "Truppen D4: " + f.tD4)) {
						f.tD4 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "Truppen D5: " + f.tD5)) {
						f.tD5 += 1;
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen D6: " + f.tD6)) {
							f.tD6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen D7: " + f.tD7)) {
							f.tD7 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "Truppen D8: " + f.tD8)) {
							f.tD8 += 1;
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen D6: " + f.tD6)) {
							f.tD6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen D7: " + f.tD7)) {
							f.tD7 += 1;
						}
					}
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 40, 0, 30, ctrlHight);
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "-")) {
						f.tD1 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "-")) {
						f.tD2 -= 1;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "-")) {
						f.tD3 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "-")) {
						f.tD4 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "-")) {
						f.tD5 -= 1;
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tD6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tD7 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "-")) {
							f.tD8 -= 1;
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tD6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tD7 -= 1;
						}
					}
				}
				if (e == 1) {
					butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 150;
					if (GUI.Button (butRect, "Zurück")) {
						truppenVerändern = 0;
						optionen = 0;
						e = 0;
					}
					if (a.map != 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "Truppen E1: " + f.tE1)) {
						f.tE1 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "Truppen E2: " + f.tE2)) {
						f.tE2 += 1;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "Truppen E3: " + f.tE3)) {
						f.tE3 += 1;
					}
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "Truppen E4: " + f.tE4)) {
						f.tE4 += 1;
					}
					if (a.map != 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "Truppen E5: " + f.tE5)) {
						f.tE5 += 1;
					}
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen E6: " + f.tE6)) {
							f.tE6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen E7: " + f.tE7)) {
							f.tE7 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "Truppen E8: " + f.tE8)) {
							f.tE8 += 1;
						}
					}

					butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 40, 0, 30, ctrlHight);
					if (a.map != 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "-")) {
						f.tE1 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "-")) {
						f.tE2 -= 1;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "-")) {
						f.tE3 -= 1;
					}
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "-")) {
						f.tE4 -= 1;
					}
					if (a.map != 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "-")) {
						f.tE5 -= 1;
					}
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tE6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tE7 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "-")) {
							f.tE8 -= 1;
						}
					}
				}
				if (fi == 1) {
					butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 2 - 150;
					if (GUI.Button (butRect, "Zurück")) {
						truppenVerändern = 0;
						optionen = 0;
						fi = 0;
					}
					
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "Truppen F1: " + f.tF1)) {
						f.tF1 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "Truppen F2: " + f.tF2)) {
						f.tF2 += 1;
					}
					
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "Truppen F3: " + f.tF3)) {
						f.tF3 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "Truppen F4: " + f.tF4)) {
						f.tF4 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "Truppen F5: " + f.tF5)) {
						f.tF5 += 1;
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen F6: " + f.tF6)) {
							f.tF6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen F7: " + f.tF7)) {
							f.tF7 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "Truppen F8: " + f.tF8)) {
							f.tF8 += 1;
						}
					}
					if (a.map == 3) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "Truppen F6: " + f.tF6)) {
							f.tF6 += 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "Truppen F7: " + f.tF7)) {
							f.tF7 += 1;
						}
					}
					butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 40, 0, 30, ctrlHight);
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 110;
					if (GUI.Button (butRect, "-")) {
						f.tF1 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 - 70;
					if (GUI.Button (butRect, "-")) {
						f.tF2 -= 1;
					}
				
					butRect.y = (Screen.height - ctrlHight) / 2 - 30;
					if (GUI.Button (butRect, "-")) {
						f.tF3 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 10;
					if (GUI.Button (butRect, "-")) {
						f.tF4 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 50;
					if (GUI.Button (butRect, "-")) {
						f.tF5 -= 1;
					}
					if (a.map == 2) {
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tF6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tF7 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 170;
						if (GUI.Button (butRect, "-")) {
							f.tF8 -= 1;
						}
					}
					if (a.map == 3) {
						butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 40, 0, 30, ctrlHight);
						butRect.y = (Screen.height - ctrlHight) / 2 + 90;
						if (GUI.Button (butRect, "-")) {
							f.tF6 -= 1;
						}
						butRect.y = (Screen.height - ctrlHight) / 2 + 130;
						if (GUI.Button (butRect, "-")) {
							f.tF7 -= 1;
						}
					}
				}
			if (g == 1) {
				butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
				butRect.y = (Screen.height - ctrlHight) / 2 - 150;
				if (GUI.Button (butRect, "Zurück")) {
					truppenVerändern = 0;
					optionen = 0;
					g = 0;
				}
					
				butRect.y = (Screen.height - ctrlHight) / 2 - 110;
				if (GUI.Button (butRect, "Truppen G1: " + f.tG1)) {
					f.tG1 += 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 - 70;
				if (GUI.Button (butRect, "Truppen G2: " + f.tG2)) {
					f.tG2 += 1;
				}
					if (a.map != 3) {
				butRect.y = (Screen.height - ctrlHight) / 2 - 30;
				if (GUI.Button (butRect, "Truppen G3: " + f.tG3)) {
					f.tG3 += 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 + 10;
				if (GUI.Button (butRect, "Truppen G4: " + f.tG4)) {
					f.tG4 += 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 + 50;
				if (GUI.Button (butRect, "Truppen G5: " + f.tG5)) {
					f.tG5 += 1;
				}
					}
				if (a.map == 2) {
					butRect.y = (Screen.height - ctrlHight) / 2 + 90;
					if (GUI.Button (butRect, "Truppen G6: " + f.tG6)) {
						f.tG6 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 130;
					if (GUI.Button (butRect, "Truppen G7: " + f.tG7)) {
						f.tG7 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 170;
					if (GUI.Button (butRect, "Truppen G8: " + f.tG8)) {
						f.tG8 += 1;
					}
				}
				if (a.map == 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 + 90;
					if (GUI.Button (butRect, "Truppen G6: " + f.tG6)) {
						f.tG6 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 130;
					if (GUI.Button (butRect, "Truppen G7: " + f.tG7)) {
						f.tG7 += 1;
					}
				}
				butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 40, 0, 30, ctrlHight);
							
				butRect.y = (Screen.height - ctrlHight) / 2 - 110;
				if (GUI.Button (butRect, "-")) {
					f.tG1 -= 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 - 70;
				if (GUI.Button (butRect, "-")) {
					f.tG2 -= 1;
				}
					if (a.map != 3) {		
				butRect.y = (Screen.height - ctrlHight) / 2 - 30;
				if (GUI.Button (butRect, "-")) {
					f.tG3 -= 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 + 10;
				if (GUI.Button (butRect, "-")) {
					f.tG4 -= 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 + 50;
				if (GUI.Button (butRect, "-")) {
					f.tG5 -= 1;
				}
					}
				if (a.map == 2) {
					butRect.y = (Screen.height - ctrlHight) / 2 + 90;
					if (GUI.Button (butRect, "-")) {
						f.tG6 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 130;
					if (GUI.Button (butRect, "-")) {
						f.tG7 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 170;
					if (GUI.Button (butRect, "-")) {
						f.tG8 -= 1;
					}
				}
				if (a.map == 3) {
					butRect.y = (Screen.height - ctrlHight) / 2 + 90;
					if (GUI.Button (butRect, "-")) {
						f.tG6 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 130;
					if (GUI.Button (butRect, "-")) {
						f.tG7 -= 1;
					}
				}
			}
			if (h == 1) {
				butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
				butRect.y = (Screen.height - ctrlHight) / 2 - 150;
				if (GUI.Button (butRect, "Zurück")) {
					truppenVerändern = 0;
					optionen = 0;
					h = 0;
				}
					
				butRect.y = (Screen.height - ctrlHight) / 2 - 110;
				if (GUI.Button (butRect, "Truppen H1: " + f.tH1)) {
					f.tH1 += 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 - 70;
				if (GUI.Button (butRect, "Truppen H2: " + f.tH2)) {
					f.tH2 += 1;
				}
					
				butRect.y = (Screen.height - ctrlHight) / 2 - 30;
				if (GUI.Button (butRect, "Truppen H3: " + f.tH3)) {
					f.tH3 += 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 + 10;
				if (GUI.Button (butRect, "Truppen H4: " + f.tH4)) {
					f.tH4 += 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 + 50;
				if (GUI.Button (butRect, "Truppen H5: " + f.tH5)) {
					f.tH5 += 1;
				}
				if (a.map == 2) {
					butRect.y = (Screen.height - ctrlHight) / 2 + 90;
					if (GUI.Button (butRect, "Truppen H6: " + f.tH6)) {
						f.tH6 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 130;
					if (GUI.Button (butRect, "Truppen H7: " + f.tH7)) {
						f.tH7 += 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 170;
					if (GUI.Button (butRect, "Truppen H8: " + f.tH8)) {
						f.tH8 += 1;
					}
				}
				butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 40, 0, 30, ctrlHight);
								
				butRect.y = (Screen.height - ctrlHight) / 2 - 110;
				if (GUI.Button (butRect, "-")) {
					f.tH1 -= 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 - 70;
				if (GUI.Button (butRect, "-")) {
					f.tH2 -= 1;
				}
								
				butRect.y = (Screen.height - ctrlHight) / 2 - 30;
				if (GUI.Button (butRect, "-")) {
					f.tH3 -= 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 + 10;
				if (GUI.Button (butRect, "-")) {
					f.tH4 -= 1;
				}
				butRect.y = (Screen.height - ctrlHight) / 2 + 50;
				if (GUI.Button (butRect, "-")) {
					f.tH5 -= 1;
				}
				if (a.map == 2) {
					butRect.y = (Screen.height - ctrlHight) / 2 + 90;
					if (GUI.Button (butRect, "-")) {
						f.tH6 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 130;
					if (GUI.Button (butRect, "-")) {
						f.tH7 -= 1;
					}
					butRect.y = (Screen.height - ctrlHight) / 2 + 170;
					if (GUI.Button (butRect, "-")) {
						f.tH8 -= 1;
					}
				}
			}

	} else ToggleTimeScale ();
		}
}
	public void ToggleTimeScale(){ 
		if (!ispause) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
			optionen = 0;
			aufgeben = 0;
			a.statistik = 0;
			hauptmenu = 0;
		}
		ispause = !ispause;
	}
}

