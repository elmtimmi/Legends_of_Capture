using UnityEngine;
using System.Collections;

public class LandA3 : MonoBehaviour {
	public GameObject AngriffVerschiebung;
	private AngriffS a; 
	private ATruppen b;
	private Ausbilden c;
	private tAusbilden d;
	public GameObject Ausbilden;
	public GameObject RotDran;
	private Rotistdran e;
	public GameObject spawnPoint;
	private spawnPoint f;
	public GameObject Bauen;
	private BauenS g;
	public GameObject TruppenZahlen;
	int Land;
	int kasernen;
	int rathaus;
	int gebäude;
	int farbevomland;
	int durchlaufbauen;
	int darfangreifen;
	int meinem;
	int mauer;
	int darfeinmal;
    int tor;
    int tormeinen;
    int zweimal;
    int hafen;
    void OnMouseDown(){
		if (e.map != 3) {
            if (farbevomland == e.anDerReihe)
            {
                if (e.schiffangriff == 0)
                {
                    if (a.Landa == 1)
                    {
                        Debug.Log("mouse down");
                        a.Landa = 2;
                        Land = 1;
                    }
                    if (a.Landa == 3)
                    {
                        b.aTruppen = 0;
                        Land = 3;
                        a.Landa = 4;
                    }
                    else if (a.Landv == 4)
                    {
                        Land = 4;
                        a.Landv = 5;
                    }
                }
                if (f.bBustabe == -1)
                {
                    f.abriss = 13;
                    if (gebäude < 3)
                    {
                        f.bBustabe = 1;
                        f.bZahl = 3;
                        f.gebäude = gebäude;
                        if (g.gebäude == 2)
                        {
                            kasernen++;
                            Debug.Log("kasernen" + kasernen);
                            gebäude++;
                        }
                        if (g.gebäude == 3)
                        {
                            gebäude++;
                        }
                        if (g.gebäude == 5)
                        {
                            gebäude++;
                            hafen++;

                        }

                        if (g.gebäude == 1)
                        {
                            if (rathaus != 1)
                            {
                                f.bBustabe = 1;
                                f.bZahl = 3;
                                f.landNummer = 13;
                                f.gebäude = gebäude;

                                rathaus = 1;
                                if (farbevomland == 1)
                                {
                                    e.länderRot++;
                                }
                                if (farbevomland == 2)
                                {
                                    e.länderBlau++;
                                }
                                if (farbevomland == 3)
                                {
                                    e.länderGrün++;
                                }
                                if (farbevomland == 4)
                                {
                                    e.länderGelb++;
                                }
                            }
                        }
                        f.darmauerbauen = tor;
                        if (tor == 0)
                        {
                            f.darmauerbauen = mauer;
                        }
                        if (tor == 0)
                        {
                            if (mauer == 0)
                            {
                                if (g.wmauer != 0)
                                {
                                    meinem = g.wmauer;
                                    mauer = 1;
                                }
                                if (g.wtor != 0)
                                {
                                    tormeinen = g.wtor;
                                    tor = 1;
                                }
                            }
                        }
                    }
                }
                if (c.ausbilden == 1)
                {
                    d.getLand = 13;
                    d.anzahl = kasernen;
                    Debug.Log("anzahl der Truppen" + d.anzahl);

                }
                if (c.ausbilden == 2)
                {
                    d.tA3 += 3;
                    c.ausbilden = 0;
                }
                if (c.ausbilden == 3)
                {
                    e.getland = 13;
                    e.getfarbe = farbevomland;
                    e.hafen = hafen;
                    Debug.Log(e.getland);

                }
            }
            else if (a.Landv == 1)
            {
                a.Landv = 2;
                Land = 2;
                if (e.schiffangriff == 1)
                {
                    e.angreifen = 1;
                }
            }
        }
    }
	// Use this for initialization
	void Start () {
        //
        farbevomland = 1;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        //
        a = AngriffVerschiebung.GetComponent<AngriffS> ();
		b = AngriffVerschiebung.GetComponent<ATruppen> ();
		c = Ausbilden.GetComponent<Ausbilden> ();
		d = Ausbilden.GetComponent<tAusbilden> ();
		e = RotDran.GetComponent<Rotistdran> ();
		f = spawnPoint.GetComponent<spawnPoint > ();
		g = Bauen.GetComponent<BauenS > ();
	}
	
	// Update is called once per frame
	void Update () {
		if (e.map != 3) {
            if (c.ausbilden == 4)
            {
                if (e.anDerReihe == farbevomland)
                {
                    d.tA3 += kasernen;
                }
            }
            if (Land == 1)
            {
                if (a.angriff == 2)
                {
                    if (rathaus != 1)
                    {
                        a.angriff = 1;
                    }
                }
                if (darfeinmal == 0)
                {
                    if (a.spezAngriff == 1)
                    {
                        d.tA3 *= 2;
                        darfeinmal = 1;
                    }
                }
                f.landNummer = 13;
                a.angreiferm = meinem;
                if (d.tA3 == 0)
                {
                    b.aTruppen = -1;
                    Land = 0;
                }
                else
                    b.aTruppen = d.tA3;

                if (b.aGewonnen == 2)
                {
                    d.tA3 = 0;
                    Land = 0;
                }
                else if (b.aGewonnen == 1)
                {
                    d.tA3 = 0;
                }
            }
            if (Land == 2) {
			if (f.landNummer == 12) {
                    if (tormeinen == 2)
                    {
                        zweimal = 1;
                    }
                    if (a.angreiferm == 4) {
					darfangreifen = 0;
				} else if (meinem == 2) {
					darfangreifen = 0;
				} else
					darfangreifen = 1;
			} else if (f.landNummer == 14) {
                    if (tormeinen == 4)
                    {
                        zweimal = 1;
                    }
                    if (a.angreiferm == 2) {
					darfangreifen = 0;
				} else if (meinem == 4) {
					darfangreifen = 0;
				} else
					darfangreifen = 1;
			} else if (f.landNummer == 23) {
                    if (tormeinen == 3)
                    {
                        zweimal = 1;
                    }
                    if (a.angreiferm == 1) {
					darfangreifen = 0;
				} else if (meinem == 3) {
					darfangreifen = 0;
				} else
					darfangreifen = 1;
			}
			if(a.spezAngriff == 2){
				if(rathaus != 1){
					if(d.tA3 == 0){
						darfangreifen = 1;
					}
				}
			}
                if (e.schiffangriff == 1)
                {
                    darfangreifen = 1;
                }
                if (darfangreifen == 1)
                {
                    if (d.tA3 != 0)
                    {
                        b.vTruppen = d.tA3;
                        if (zweimal == 1)
                        {
                            b.vTruppen *= 2;
                        }
                    }
                    if (rathaus > 0) {
					b.vTruppen += 1;
				} else if (d.tA3 == 0) {
					b.vTruppen = -1;
				}
			
				if (b.aGewonnen == 2) {
					d.tA3 = 0 - b.gTruppen;
					Land = 0;
					b.vTruppen = 0;
				}
				if (b.vTruppen != 0) {
					if (Land == 2) {
						if (b.aGewonnen == 1) {
							if (rathaus > 0) {
								if (farbevomland == 1) {
									e.länderRot --;
								}
								if (farbevomland == 2) {
									e.länderBlau --;
								}
								if (farbevomland == 3) {
									e.länderGrün --;
								}
								if (farbevomland == 4) {
									e.länderGelb --;
								}
							}
					
							if (e.anDerReihe == 1) {
								gameObject.GetComponent<Renderer> ().material.color = Color.red;
								farbevomland = 1;
							} else if (e.anDerReihe == 2) {
								gameObject.GetComponent<Renderer> ().material.color = Color.blue;
								farbevomland = 2;
							} else if (e.anDerReihe == 3) {
								gameObject.GetComponent<Renderer> ().material.color = Color.green;
								farbevomland = 3;
							} else if (e.anDerReihe == 4) {
								gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
								farbevomland = 4;
							}
							Land = 0;
                                hafen = 0;
                                d.tA3 = b.gTruppen;
							kasernen = 0;
							rathaus = 0;
							gebäude = 0;
							a.angriff = 0;
							mauer = 0;
                                tormeinen = 0;
                                tor = 0;
                                e.landerobert = 13;
                                meinem = 0;
							darfangreifen = 0;
							f.abriss = 130;
							if(a.spezAngriff == 1){
								d.tA3 /= 2;
								a.spezAngriff = 0;
							}
						}
					}
				}
			}
			if(a.angriff == 2){
				d.tA3 = (d.tA3 / 2);
				Land = 0;
			}
		}

            if (Land == 3)
            {
                if (e.schiffeverschiebung == 1)
                {
                    d.tA3 = b.gTruppen;
                }
                else
                {
                    if (d.tA3 != 0)
                    {
                        b.aTruppen = d.tA3;
                        d.tA3 = 0;
                    }
                }
            }
            if (Land == 4) {
			b.vTruppen = d.tA3;
			d.tA3 += b.gTruppen;
			Land = 0;
		}
		if (e.f == 0) {
			b.aTruppen = 0;
			durchlaufbauen = 0;
			Land = 0;
				darfeinmal = 0;
                zweimal = 0;
                Land = 0;
            }
		if (Input.GetKeyDown (KeyCode.F)) {
			b.aTruppen = 0;
			durchlaufbauen = 0;
			Land = 0;
			darfeinmal = 0;
                zweimal = 0;
                Land = 0;

            }
			if(e.map == 1){
		if (farbevomland == e.anDerReihe) {
			if(durchlaufbauen < 2){
				if(e.sternlandan == 1){
			g.zweimal = 3;
				durchlaufbauen ++;
				}
						darfeinmal = 0;
			}
		} 
			}
	}else 
		GetComponent<Renderer> ().enabled = false;
	if(e.start == 0){
		if(e.map == 4){
			GetComponent<Renderer> ().enabled = true;
		}
			if(e.map == 1){
				GetComponent<Renderer> ().enabled = true;
			}
	}
	}
}