using UnityEngine;
using System.Collections;

public class spawnPoint : MonoBehaviour {
	public GameObject Bauen;
	private BauenS a;
	public int bBustabe;
	public int bZahl;
	public int los;
	public int c;
	public int v;
	public int c3;
	public int v3;
	public int gebäude;
	public double landNummer;
	public int Rathaus;
	public int hatschongebaut;
 int hatschongebaut1;
int hatschongebaut2;
	public int hatschongebaut3;
	public int hatschongebaut4;
	public int hatschongebaut5;
	public GameObject RotDran;
	private Rotistdran b;
	public GameObject wieVieleSpieler;
	private wieVieleSpielerS d;
	public int moben;
	public int munten;
	public int mlinks;
	public int mrechts;
	public int darmauerbauen;
	public int abriss;
	int hatschongebaut8 ;
	public int kas;
	public int brück;
	public int los3;
	public int brück3;
	public int kas3;
	public int brück2;
	public int kas2;
	public int los2;
	public int einmal;
	public int los4;
	public int kas4;
	public int brück4;
	public int einmal1;

	public int hafen = 1;
	public int hafendrehung = 1;
	int h0;
	public int h1;
	int h2;
	int h3;
	int h4;
	int h5;
	int h6;
	int h7;
	int h8;
    int h9;
    int h10;
    int h11;
	public int landnummer;
    public int loswerft;
    public int werft1;

	
	//	int i;

	// Use this for initialization
	void Start () {
		//hafen = 1;
		//hafendrehung = 1;
		a = Bauen.GetComponent<BauenS > ();
		b = RotDran.GetComponent<Rotistdran> ();
		d = wieVieleSpieler.GetComponent<wieVieleSpielerS> ();
		los4 = 5;
		kas = 1;
		brück = 1;
		brück3 = 1;
		kas3 = 1;
		brück2 = 1;
		kas2 = 1;
		kas4 = 1;
		brück4 = 1;
		los3 = 5;
		los2 = 5;
		los = 5;
        werft1 = 1;

	}
	
	// Update is called once per frame
	void Update () {
		if (b.map == 4) {
            if (b.start == 1)
            {
                Debug.Log("map = 4");
                if (h1 == 0)
                {
                    Debug.Log("hafen = 1");
                    hafendrehung = 0;
                    bZahl = 10000;
                    bBustabe = 100000;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h1++;
                }
                else
                if (h2 == 0)
                {
                    hafendrehung = 1;
                    bZahl = 1;
                    bBustabe = 1;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h2++;
                }
                else
        if (h3 == 0)
                {
                    hafendrehung = 2;
                    bZahl = 1;
                    bBustabe = 1;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h3++;
                }
                else
        if (h4 == 0)
                {
                    hafendrehung = 3;
                    bZahl = 1;
                    bBustabe = 5;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h4++;
                }
                else
        if (h5 == 0)
                {
                    hafendrehung = 1;
                    bZahl = 1;
                    bBustabe = 1000000;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h5 = 1;
                    landnummer = 15;
                }
                else
        if (h6 == 0)
                {
                    hafendrehung = 0;
                    bZahl = 1000;
                    bBustabe = 1;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h6++;
                    landnummer = 11;
                }
                else
        //
        //
        //das dadrüber nicht weg mahcen!
        //
        //
        //
        //
        //ab unter diesem geht es richtig los
        //
        //hafendrehung = 1;

        if (h7 == 0)
                {
                    hafendrehung = 0;
                    bZahl = 1;
                    bBustabe = 4;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h7++;
                    landnummer = 41;
                }
                else
        if (h8 == 0)
                {
                    hafendrehung = 1;
                    bZahl = 4;
                    bBustabe = 1;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h8++;
                    landnummer = 14;
                }
                else
                if (h9 == 0)
                {
                    hafendrehung = 2;
                    bZahl = 7;
                    bBustabe = 4;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h9++;
                    landnummer = 47;
                }
                else
                if (h10 == 0)
                {
                    hafendrehung = 3;
                    bZahl = 4;
                    bBustabe = 7;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h10++;
                    landnummer = 74;
                }

                else
                if (h11 == 0)
                {
                    hafendrehung = 2;
                    bZahl = -10;
                    bBustabe = 4;
                    hafen = 1;
                    c3 = ((bZahl) * 75) + 50;
                    v3 = -((bBustabe) * 75) + 445;
                    h11++;
                    landnummer = -4100;
                }
            
            if (hafendrehung == 0) {
					transform.rotation = Quaternion.identity;
				}
				if (hafendrehung == 1) {
					transform.rotation = Quaternion.identity;
					c3 += 77;
					v3 += 85;
					transform.Rotate (0, 90, 0);
				}
				if (hafendrehung == 2) {
					transform.rotation = Quaternion.identity;
					c3 += 167;
					v3 += 10;	
					transform.Rotate (0, 180, 0);
				}
				if (hafendrehung == 3) {
					transform.rotation = Quaternion.identity;
					c3 += 87;
					v3 -= 79;
					transform.Rotate (0, -90, 0);
					
				}
			}
		}
			if (hatschongebaut == 1) {
		//	abriss = 51;
			if (hatschongebaut4 == 0) {
				if (hatschongebaut2 == 0) {
					if (d.spieler == 4) {
						Debug.Log ("hatschongebaut = 1");
						if(b.map == 1){
						bZahl = 5;
						bBustabe = 5;
						}else if(b.map == 2){
							landNummer = 88;
						bZahl = 8;
						bBustabe = 8;
							c3 = ((bZahl) * 75) + 50;
							v3 = -((bBustabe) * 75) + 445;
						}
						else if(b.map == 3){
							abriss = 77;
							landNummer = 77;
							bZahl = 7;
							bBustabe = 7;
						}
						c = ((bZahl) * 75) + 30;
						v = -((bBustabe) * 75) + 470;
						transform.position = new Vector3 (c, 0f, v);
						hatschongebaut = 3;
						hatschongebaut4 = 1;
						los = 1;
						if(b.stamm4 == 3){
							los3 = 1;
							c3 = ((bZahl) * 75) + 50;
							v3 = -((bBustabe) * 75) + 445;
						}
						if(b.stamm4 == 2){
							los2 = 1;
							c3 = ((bZahl) * 75) + 31;
							v3 = -((bBustabe) * 75) + 457;
						}
						if(b.stamm4 == 4){
							los4 = 1;
							c3 = ((bZahl) * 75) + + 26;
							v3 = -((bBustabe) * 75) + 455;
						}
					}
				}
			}
		}
		if (hatschongebaut == 1) {
			if(hatschongebaut2 == 0){
				if(hatschongebaut2 == 0){
					if(d.spieler > 2){
						Debug.Log ("hatschongebaut = 2");
						abriss = 11;
						landNummer = 11;
						bZahl = 1;
						bBustabe = 1;
						if(b.andermap == 1){
							abriss = 55;
							landNummer = 55;
							bZahl = 5;
							bBustabe = 5;
						}

						c = ((bZahl) * 75) + 30;
						v = -((bBustabe) * 75) + 470;
						transform.position = new Vector3 (c, 0f, v);
						hatschongebaut = 3;
						hatschongebaut2 = 1;
						los = 1;
						if(b.stamm3 == 3){
							los3 = 1;
							c3 = ((bZahl) * 75) + 50;
							v3 = -((bBustabe) * 75) + 445;
						}
						if(b.stamm3 == 2){
							los2 = 1;
							c3 = ((bZahl) * 75) + 31;
							v3 = -((bBustabe) * 75) + 457;
						}
						if(b.stamm3 == 4){
							los4 = 1;
							c3 = ((bZahl) * 75) + + 26;
							v3 = -((bBustabe) * 75) + 455;
						}
					}
				}
			}
		}



		if (hatschongebaut == 0) {
			if (b.anDerReihe == 2) {
				Debug.Log ("hatschongebaut = 3");
				landNummer = 95;
				abriss = 55;
				bZahl = 5;
				bBustabe = 9;
				c = ((bZahl) * 75) + 30;
				v = -((bBustabe) * 75) + 470;
				transform.position = new Vector3 (c, 0f, v);
				los = 1;
					los3 = 1;
					c3 = ((bZahl) * 75) + 50;
					v3 = -((bBustabe) * 75) + 445;
					los2 = 1;
					c3 = ((bZahl) * 75) + 50;
					v3 = -((bBustabe) * 75) + 445;
					los4 = 1;
					c3 = ((bZahl) * 75) + + 26;
					v3 = -((bBustabe) * 75) + 455;


			}
		}
		if (hatschongebaut == 1) {
			if(hatschongebaut1 == 0){
					Debug.Log ("hatschongebaut1 = 4");
				if(b.map == 1){
				abriss = 15;
					landNummer = 15;
					bZahl = 5;
					bBustabe = 1;
					if(b.andermap == 1){
						abriss = 53;
						landNummer = 53;
						bZahl = 3;
						bBustabe = 5;
					}
				}else if(b.map == 2){
					abriss = 18;
					c3 = ((bZahl) * 75) + 50;
					v3 = -((bBustabe) * 75) + 445;
					landNummer = 18;
					bZahl = 8;
					bBustabe = 1;
				}else if(b.map == 3){
					abriss = 17;
					landNummer = 17;
					bZahl = 7;
					bBustabe = 1;
				}

					c = ((bZahl) * 75) + 30;
					v = -((bBustabe) * 75) + 470;
					transform.position = new Vector3 (c, 0f, v);
					hatschongebaut = 3;
					hatschongebaut1 = 1;
					los = 1;
				if(b.stamm2 == 3){
					los3 = 1;
					c3 = ((bZahl) * 75) + 50;
					v3 = -((bBustabe) * 75) + 445;
				}
				if(b.stamm2 == 2){
					los2 = 1;
					c3 = ((bZahl) * 75) + 31;
					v3 = -((bBustabe) * 75) + 457;
				}
				if(b.stamm2 == 4){
					los4 = 1;
					c3 = ((bZahl) * 75) + + 26;
					v3 = -((bBustabe) * 75) + 455;
				}
			}
		}

			
		if (hatschongebaut == 1) {
			if (hatschongebaut3 == 0) {
				Debug.Log ("hatschongebaut = 5");
				if(b.map == 1){
					abriss = 51;
				landNummer = 51;
				bZahl = 1;
				bBustabe = 5;
				}else if(b.map == 2){
					abriss = 81;
					c3 = ((bZahl) * 75) + 50;
					v3 = -((bBustabe) * 75) + 445;
					landNummer = 81;
					bZahl = 1;
					bBustabe = 8;
				         }
				else if(b.map == 3){
					abriss = 71;
					landNummer = 71;
					bZahl = 1;
					bBustabe = 7;
				}
				c = ((bZahl) * 75) + 30;
				v = -((bBustabe) * 75) + 470;
				transform.position = new Vector3 (c, 0f, v);
				hatschongebaut = 3;
				hatschongebaut3 = 1;
				los = 1;
				if(b.stamm1 == 3){
					los3 = 1;
					c3 = ((bZahl) * 75) + 50;
					v3 = -((bBustabe) * 75) + 445;
				}
				if(b.stamm1 == 2){
					los2 = 1;
					c3 = ((bZahl) * 75) + 31;
					v3 = -((bBustabe) * 75) + 457;
				}
				if(b.stamm1 == 4){
					los4 = 1;
					c3 = ((bZahl) * 75) + + 26;
					v3 = -((bBustabe) * 75) + 455;
				}
			
			}
		}
		
	if (a.bauen == 1) {
			if (bBustabe == 0) {
				bBustabe = -1;
			}
		} else
			bBustabe = 0;
		if (bBustabe > 0) {
			if(a.gebäude == 1){
				if(b.stamm == 1){
				c = ((bZahl) * 75) + 30;
				v = -((bBustabe ) * 75) + 470;
				los = 1;
				}if(b.stamm == 3){
					if(los3 == 0){
					c3 = ((bZahl) * 75) + 50;
					v3 = -((bBustabe) * 75) + 445;
					los3 = 1;
					}
				}
				if(b.stamm == 2){
					if(los3 == 0){
					c3= ((bZahl) * 75) + 31;
						v3 = -((bBustabe) * 75) + 457;
						los2 = 1;
					}
				}
				if(b.stamm == 4){
					if(los3 == 0){
						c3 = ((bZahl) * 75) + + 26;
						v3 = -((bBustabe) * 75) + 455;
						los4 = 1;
					}
				}


			}
				else if (a.gebäude > 1){
				if (b.stamm == 1) {
				c = ((bZahl) * 75) + 5;
				v = -((bBustabe) * 75) + 490;
				}
				if(b.stamm == 3){

					c3 = ((bZahl) * 75) + 5;
					v3 = -((bBustabe) * 75) + 490;
				}
				if(b.stamm == 2){
					
					c3 = ((bZahl) * 75) -2;
					v3 = -((bBustabe) * 75) + 490;
				}
				if(b.stamm == 4){
					
					c3 = ((bZahl) * 75)  + 5;
					v3 = -((bBustabe) * 75) + 490;
				}
				if(a.gebäude == 2){
					if(b.stamm == 1){
					c = ((bZahl) * 75) + 10;
					v = -((bBustabe) * 75) + 490;
					}
					if(b.stamm == 3){
						c3 = ((bZahl) * 75) + 10;
						v3 = -((bBustabe) * 75) + 490;
						los3 = 2;
					
					}
					if(b.stamm == 2){
						c3 = ((bZahl) * 75) -10;
						v3 = -((bBustabe) * 75) + 490;
						los2 = 2;
						
					}
					if(b.stamm == 4){
						c3 = ((bZahl) * 75) -5;
						v3 = -((bBustabe) * 75) + 490;
						los4 = 2;
						
					}
				}
			if(gebäude == 1){
				c  += 20;
					c3 += 20;
			}
			if(gebäude == 2){
				c  += 40;
					c3 += 40;
			}
				if(a.gebäude == 2){
					if(b.stamm == 1){
				los = 2;
					}
				}else if(a.gebäude == 3){
					if(b.stamm == 1){
					los = 3;
					}
				if(b.stamm == 3){
					los3 = 3;
				}
					if(b.stamm == 2){
						los2 = 3;
					}
					if(b.stamm == 4){
						los4 = 3;
						transform.position = new Vector3 (c, 0f, v);
					}

			}
               else if(a.gebäude == 5)
                {
                    c3 = ((bZahl) * 75) - 10;
                    v3 = -((bBustabe) * 75) + 490;
                    if (gebäude == 1)
                    {
                        c += 20;
                        c3 += 20;
                    }
                    if (gebäude == 2)
                    {
                        c += 40;
                        c3 += 40;
                    }
                    transform.position = new Vector3(c, 0f, v);
                    loswerft = 1;
                }
					}
			transform.position = new Vector3(c, 0f, v);
			a.bauen = 0;
			if(a.zweimal != 0){
				a.zweimal --;
			}
		}
		if(bBustabe > 0){
			if(darmauerbauen == 0){
			if(a.wmauer == 1){
				c = ((bZahl) * 75) + 25;
				v = -((bBustabe ) * 75) + 507;
				transform.position = new Vector3 (c, 0f, v);
				transform.Rotate(0,90,0);
				los = 4;
			a.wmauer = 0;
			}
			if(a.wmauer == 2){
				c = ((bZahl) * 75) + -7;
				v = -((bBustabe ) * 75) + 474;
				transform.position = new Vector3 (c, 0f, v);
				los = 4;
				a.wmauer = 0;
			}
			if(a.wmauer == 3){
				c = ((bZahl) * 75) + 25;
				v = -((bBustabe ) * 75) + 445;
				transform.position = new Vector3 (c, 0f, v);
				transform.Rotate(0,90,0);
				los = 4;
				a.wmauer = 0;
			}
			if(a.wmauer == 4){
				c = ((bZahl) * 75) + 55;
				v = -((bBustabe ) * 75) + 474;
				transform.position = new Vector3 (c, 0f, v);
				los = 4;
				a.wmauer = 0;
			}

		}
		}
		if(bBustabe > 0){
			if(darmauerbauen == 0){
				if(a.wtor == 1){
					c = ((bZahl) * 75) ;
					v = -((bBustabe ) * 75) + 507;
					transform.position = new Vector3 (c, 0f, v);
					los = 6;
					a.wtor = 0;
				}
				if(a.wtor == 2){
					c = ((bZahl) * 75) + -7;
					v = -((bBustabe ) * 75) + 500;
					transform.Rotate(0,90,0);
					transform.position = new Vector3 (c, 0f, v);
					los = 6;
					a.wtor = 0;
				}
				if(a.wtor == 3){
					c = ((bZahl) * 75);
					v = -((bBustabe ) * 75) + 445;
					transform.position = new Vector3 (c, 0f, v);
					los = 6;
					a.wtor = 0;
				}
				if(a.wtor == 4){
					c = ((bZahl) * 75) + 55;
					v = -((bBustabe ) * 75) + 500;
					transform.position = new Vector3 (c, 0f, v);
					los = 6;
					a.wtor = 0;
					transform.Rotate(0,90,0);
				}
				
			}
		}
		if (b.f == 0) {
			transform.rotation = Quaternion.identity;
			hafendrehung = 0;
			landNummer = 0;
			darmauerbauen = 0;
			if(hatschongebaut1 == 1){
			los3 = 0;
			}
			abriss = 0;
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			transform.rotation = Quaternion.identity;
			hafendrehung = 0;
			landNummer = 0;
			darmauerbauen = 0;
			if(hatschongebaut1 == 1){
				los3 = 0;
				abriss = 0;
			}
		}
	}
}
