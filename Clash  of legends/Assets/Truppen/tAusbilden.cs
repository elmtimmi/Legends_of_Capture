using UnityEngine;
using System.Collections;

public class tAusbilden : MonoBehaviour {
	public GameObject Ausbilden;
	private Ausbilden a;
	public int getLand;
	public int anzahl;
	public int superstern;
	public GameObject RotDran;
	private Rotistdran e;
	int einmal;
	public GameObject MainCamera;
	private camaraBewegt b;

	public int tA1;
	public int tA2;
	public int tA3;
	public int tA4;
	public int tA5;
	public int tA6;
	public int tA7;
	public int tA8;

	public int tB1;
	public int tB2;
	public int tB3;
	public int tB4;
	public int tB5;
	public int tB6;
	public int tB7;
	public int tB8;
    public int tBm11;
    public int tB29;


    public int tC1;
	public int tC2;
	public int tC3;
	public int tC4;
	public int tC5;
	public int tC6;
	public int tC7;
	public int tC8;
    public int tCm10;
    public int tCm11;
    public int tC28;
    public int tC29;

    public int tD1;
	public int tD2;
	public int tD3;
	public int tD4;
	public int tD5;
	public int tD6;
	public int tD7;
	public int tD8;
    public int tDm10;
    public int tDm11;
    public int tD28;
    public int tD29;

    public int tE1;
	public int tE2;
	public int tE3;
	public int tE4;
	public int tE5;
	public int tE6;
	public int tE7;
	public int tE8;
    public int tEm10;
    public int tEm11;
    public int tE28;
    public int tE29;


    public int tF1;
	public int tF2;
	public int tF3;
	public int tF4;
	public int tF5;
	public int tF6;
	public int tF7;
	public int tF8;
    public int tFm11;
    public int tF29;


    public int tG1;
	public int tG2;
	public int tG3;
	public int tG4;
	public int tG5;
	public int tG6;
	public int tG7;
	public int tG8;

	public int tH1;
	public int tH2;
	public int tH3;
	public int tH4;
	public int tH5;
	public int tH6;
	public int tH7;
	public int tH8;

    public int tmIm11;
    public int tmI29;

    public int tmJ3;
    public int tmJ4;
    public int tmJ5;
    public int tmJm11;
    public int tmJm10;
    public int tmJ28;
    public int tmJ29;

    public int tmK2;
    public int tmK3;
    public int tmK4;
    public int tmK5;
    public int tmK6;
    public int tmKm9;
    public int tmKm10;
    public int tmKm11;
    public int tmK27;
    public int tmK28;
    public int tmK29;

    public int tR29;
    public int tRm11;

    public int tS3;
    public int tS4;
    public int tS5;
    public int tS28;
    public int tS29;
    public int tSm10;
    public int tSm11;

    public int tT2;
    public int tT3;
    public int tT4;
    public int tT5;
    public int tT6;
    public int tT27;
    public int tT28;
    public int tT29;
    public int tTm9;
    public int tTm10;
    public int tTm11;



    int x;
	int y;
	int ax;
	// Use this for initialization
	void Start () {
	//	tA1 = 100;
	//	tA2 = 1;
		a = Ausbilden.GetComponent<Ausbilden> ();
		e = RotDran.GetComponent<Rotistdran> ();
		b =MainCamera .GetComponent<camaraBewegt> ();
	}
	void OnGUI() {
		if (e.anDerReihe == 2) {
			einmal = 1;
		}

		if (einmal == 1) {
            if (b.hatsichbewegt == 0)
            {
                if (e.map == 1)
                {
                   
                    x = 490;
                    y = 100;
                    ax = 100;
                    GUI.Label(new Rect(x, 90, 100, 100), "Truppen : " + tA1);
                    GUI.Label(new Rect(x + 100, 90, 100, 100), "Truppen : " + tA2);
                    GUI.Label(new Rect(x + 200, 90, 100, 100), "Truppen : " + tA3);
                    GUI.Label(new Rect(x + 300, 90, 100, 100), "Truppen : " + tA4);
                    GUI.Label(new Rect(x + 400, 90, 100, 100), "Truppen : " + tA5);

                    GUI.Label(new Rect(x, 190, 100, 100), "Truppen : " + tB1);
                    GUI.Label(new Rect(x + 100, 190, 100, 100), "Truppen : " + tB2);
                    GUI.Label(new Rect(x + 200, 190, 100, 100), "Truppen : " + tB3);
                    GUI.Label(new Rect(x + 300, 190, 100, 100), "Truppen : " + tB4);
                    GUI.Label(new Rect(x + 400, 190, 100, 100), "Truppen : " + tB5);

                    GUI.Label(new Rect(x, 290, 100, 100), "Truppen : " + tC1);
                    GUI.Label(new Rect(x + 100, 290, 100, 100), "Truppen : " + tC2);
                    GUI.Label(new Rect(x + 200, 290, 100, 100), "Truppen : " + tC3);
                    GUI.Label(new Rect(x + 300, 290, 100, 100), "Truppen : " + tC4);
                    GUI.Label(new Rect(x + 400, 290, 100, 100), "Truppen : " + tC5);

                    GUI.Label(new Rect(x, 390, 100, 100), "Truppen : " + tD1);
                    if (e.andermap != 1)
                    {
                        GUI.Label(new Rect(x + 100, 390, 100, 100), "Truppen : " + tD2);
                    }
                    GUI.Label(new Rect(x + 200, 390, 100, 100), "Truppen : " + tD3);
                    if (e.andermap != 1)
                    {
                        GUI.Label(new Rect(x + 300, 390, 100, 100), "Truppen : " + tD4);
                    }
                    GUI.Label(new Rect(x + 400, 390, 100, 100), "Truppen : " + tD5);
                    GUI.Label(new Rect(x, 490, 100, 100), "Truppen : " + tE1);
                    if (e.andermap != 1)
                    {
                        GUI.Label(new Rect(x + 100, 490, 100, 100), "Truppen : " + tE2);
                    }
                    GUI.Label(new Rect(x + 200, 490, 100, 100), "Truppen : " + tE3);
                    if (e.andermap != 1)
                    {
                        GUI.Label(new Rect(x + 300, 490, 100, 100), "Truppen : " + tE4);
                    }
                    GUI.Label(new Rect(x + 400, 490, 100, 100), "Truppen : " + tE5);
                }
                if (e.map > 1)
                {
                    if (b.position == 0)
                    {

                        x = 460;
                    ax = 71;
                    y = 63;
                    if (e.map != 4)
                    {
                        GUI.Label(new Rect(x, y, 100, 100), "Truppen : " + tA1);
                        GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tA2);
                    }
                    if (e.map != 3)
                    {
                        GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tA3);
                        GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tA4);
                        GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tA5);
                    }
                    if (e.map != 4)
                    {
                        GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tA6);
                        GUI.Label(new Rect(x + ax * 6, y, 100, 100), "Truppen : " + tA7);
                        if (e.map != 3)
                        {
                            GUI.Label(new Rect(x + ax * 7, y, 100, 100), "Truppen : " + tA8);
                        }
                    }
                    y = 134;
                    if (e.map != 4)
                    {
                        GUI.Label(new Rect(x, y, 100, 100), "Truppen : " + tB1);
                    }
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tB2);
                    if (e.map > 2)
                    {
                        GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tB3);
                    }
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tB4);
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tB5);
                    if (e.map != 2)
                    {
                        GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tB6);
                    }
                    if (e.map != 4)
                    {
                        GUI.Label(new Rect(x + ax * 6, y, 100, 100), "Truppen : " + tB7);
                        if (e.map != 3)
                        {
                            GUI.Label(new Rect(x + ax * 7, y, 100, 100), "Truppen : " + tB8);
                        }
                    }
                    y = 205;
                    if (e.map != 3)
                    {
                        GUI.Label(new Rect(x, y, 100, 100), "Truppen : " + tC1);
                        GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tC2);
                        GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tC3);
                    }
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tC4);
                    if (e.map != 3)
                    {
                        GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tC5);
                        if (e.map != 2)
                        {
                            GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tC6);
                            GUI.Label(new Rect(x + ax * 6, y, 100, 100), "Truppen : " + tC7);
                        }
                        if (e.map != 4)
                        {
                            GUI.Label(new Rect(x + ax * 7, y, 100, 100), "Truppen : " + tC8);
                        }
                    }
                    y = 276;
                    GUI.Label(new Rect(x, y, 100, 100), "Truppen : " + tD1);
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tD2);
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tD3);
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tD4);
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tD5);
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tD6);
                    GUI.Label(new Rect(x + ax * 6, y, 100, 100), "Truppen : " + tD7);
                    if (e.map != 3)
                    {
                        if (e.map != 4)
                        {
                            GUI.Label(new Rect(x + ax * 7, y, 100, 100), "Truppen : " + tD8);
                        }
                    }
                    y = 347;
                    if (e.map != 3)
                    {
                        GUI.Label(new Rect(x, y, 100, 100), "Truppen : " + tE1);
                        GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tE2);
                        GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tE3);
                    }
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tE4);
                    if (e.map != 3)
                    {
                        GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tE5);
                        GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tE6);
                        GUI.Label(new Rect(x + ax * 6, y, 100, 100), "Truppen : " + tE7);
                        if (e.map != 4)
                        {
                            GUI.Label(new Rect(x + ax * 7, y, 100, 100), "Truppen : " + tE8);
                        }
                    }

                    y = 418;
                    if (e.map != 4)
                    {
                        GUI.Label(new Rect(x, y, 100, 100), "Truppen : " + tF1);
                    }
                    if (e.map != 2)
                    {
                        GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tF2);
                        GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tF3);
                    }
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tF4);
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tF5);
                    if (e.map != 2)
                    {
                        GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tF6);
                        if (e.map != 4)
                        {
                            GUI.Label(new Rect(x + ax * 6, y, 100, 100), "Truppen : " + tF7);
                        }
                    }
                    if (e.map != 3)
                    {
                        if (e.map != 4)
                        {
                            GUI.Label(new Rect(x + ax * 7, y, 100, 100), "Truppen : " + tF8);
                        }
                    }
                    y = 489;
                    if (e.map != 4)
                    {
                        GUI.Label(new Rect(x, y, 100, 100), "Truppen : " + tG1);
                        GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tG2);
                    }
                    if (e.map != 3)
                    {
                        if (e.map != 2)
                        {
                            GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tG3);
                        }
                        GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tG4);
                                GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tG5);
                    }
                        if (e.map != 2)
                        {
                            if (e.map != 4)
                            {
                                GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tG6);
                            }
                        }
                    if (e.map != 4)
                    {
                        GUI.Label(new Rect(x + ax * 6, y, 100, 100), "Truppen : " + tG7);
                        if (e.map != 3)
                        {
                            GUI.Label(new Rect(x + ax * 7, y, 100, 100), "Truppen : " + tG8);
                        }
                        y = 560;
                        if (e.map != 4)
                        {
                            GUI.Label(new Rect(x, y, 100, 100), "Truppen : " + tH1);
                            GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tH2);
                            GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tH3);
                            GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tH4);
                            GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tH5);
                            GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tH6);
                            GUI.Label(new Rect(x + ax * 6, y, 100, 100), "Truppen : " + tH7);
                            GUI.Label(new Rect(x + ax * 7, y, 100, 100), "Truppen : " + tH8);
                        }
                    }
                    }else if(b.position == 1)
                    {
                        x = 460;
                        ax = 71;
                        y = 60;
                        GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tmK2);
                        GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tmK3);
                        GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tmK4);
                        GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tmK5);
                        GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tmK6);
                        y = y + 71;
                        GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tmJ3);
                        GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tmJ4);
                        GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tmJ5);


                    }
                }
               if (b.position == 2)
                {
                    x = 460;
                    ax = 71;
                    y = 60;
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tmK27);
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tmK28);
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tmK29);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tmJ28);
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tmJ29);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tmI29);
                }
                if (b.position == 3)
                {
                    x = 460;
                    ax = 71;
                    y = 60;
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tB29);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tC28);
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tC29);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tD28);
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tD29);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tE28);
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tE29);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tF29);
                }
                if (b.position == 4)
                {
                    x = 460;
                    ax = 71;
                    y = 60;
                    y = y + 71;
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tR29);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tS29);
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tS28);
                         y = y + 71;
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tT29);
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tT28);
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tT27);
                }
                if (b.position == 5)
                {
                    x = 460;
                    ax = 71;
                    y = 60;
                    y = y + 71;
                    y = y + 71;
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tS3);
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tS4);
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tS5);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tT2);
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tT3);
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tT4);
                    GUI.Label(new Rect(x + ax * 4, y, 100, 100), "Truppen : " + tT5);
                    GUI.Label(new Rect(x + ax * 5, y, 100, 100), "Truppen : " + tT6);
                }
                if (b.position == 6)
                {
                    x = 460;
                    ax = 71;
                    y = 60;
                    y = y + 71;
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tRm11);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tSm11);
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tSm10);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tTm11);
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tTm10);
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tTm9);
                }
                if (b.position == 7)
                {
                    x = 460;
                    ax = 71;
                    y = 60;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tBm11);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tCm11);
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tCm10);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tDm11);
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tDm10);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tEm11);
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tEm10);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tFm11);
                }
                if (b.position == 8)
                {
                    x = 460;
                    ax = 71;
                    y = 60;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tBm11);
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tCm10);
                    GUI.Label(new Rect(x + ax * 3, y, 100, 100), "Truppen : " + tCm10);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tCm11);
                    GUI.Label(new Rect(x + ax * 2, y, 100, 100), "Truppen : " + tCm10);
                    y = y + 71;
                    GUI.Label(new Rect(x + ax * 1, y, 100, 100), "Truppen : " + tDm11);
                }
            }
			}
		}


	// Update is called once per frame
	void Update () {
		if (a.ausbilden == 1) {
			if(getLand != 0){
			if (getLand == 11) {
				tA1 += anzahl;
			}
			if (getLand == 12) {
				tA2 += anzahl;
			}
			
			if (getLand == 13) {
				tA3 += anzahl;
					if(e.andermap == 1){
						tA3 += (anzahl * superstern);
						tA3 -= anzahl;
					}
			}
			if (getLand == 14) {
				tA4 += anzahl;
			}
			if (getLand == 15) {
				tA5 += anzahl;
			}
				if (getLand == 16) {
					tA6 += anzahl;
				}
				if (getLand == 17) {
					tA7 += anzahl;
				}
				if (getLand == 18) {
					tA8 += anzahl;
				}
					if (getLand == 21) {
						tB1 += anzahl;
					}
					if (getLand == 22) {
						tB2 += anzahl;
					}
					
					if (getLand == 23) {
						tB3 += anzahl;
					}
					if (getLand == 24) {
						tB4 += anzahl;
					}
					if (getLand == 25) {
						tB5 += anzahl;
					}
				if (getLand == 26) {
					tB6 += anzahl;
				}
				if (getLand == 27) {
					tB7 += anzahl;
				}
				if (getLand == 28) {
					tB8 += anzahl;
				}
						if (getLand == 31) {
							tC1 += anzahl;
						}
						if (getLand == 32) {
							tC2 += anzahl;
						}
						
						if (getLand == 33) { tC3 += anzahl;
						}
						if (getLand == 34) {
					if(e.map == 1){
						if(e.andermap == 0){
							anzahl *= superstern;
							tC4 += anzahl;
						}else tC4 += anzahl;
					}else
							tC4 += anzahl;
						}
						if (getLand == 35) {
							tC5 += anzahl;
						}
				if (getLand == 36) {
					tC6 += anzahl;
				}
				if (getLand == 37) {
					tC7 += anzahl;
				}
				if (getLand == 38) {
					tC8 += anzahl;
				}
							if (getLand == 41) {
								tD1 += anzahl;
							}
							if (getLand == 42) {
								tD2 += anzahl;
							}
							
							if (getLand == 43) {
					tD3 += anzahl;
						}
							if (getLand == 44) {
					if(e.map != 3){
						tD4 += anzahl;
				}else{
						anzahl *= superstern;
						tD4 += anzahl;
				}
				}
				if (getLand == 45) {
								tD5 += anzahl;
							}
				if (getLand == 46) {
					tD6 += anzahl;
				}
				if (getLand == 47) {
					tD7 += anzahl;
				}
				if (getLand == 48) {
					tD8 += anzahl;
				}
                if (getLand == -4110)
                {
                    tDm11 += anzahl;
                }
                if (getLand == 51) {
									tE1 += anzahl;
								}
								if (getLand == 52) {
									tE2 += anzahl;
								}
								
								if (getLand == 53) {
									tE3 += anzahl;
								}
								if (getLand == 54) {
									tE4 += anzahl;
								}
								if (getLand == 55) {
									tE5 += anzahl;
								}
				if (getLand == 56) {
					tE6 += anzahl;
				}
				if (getLand == 57) {
					tE7 += anzahl;
				}
				if (getLand == 58) {
					tE8 += anzahl;
				}
				if (getLand == 61) {
					tF1 += anzahl;
				}
				if (getLand == 62) {
					tF2 += anzahl;
				}
				
				if (getLand == 63) {
					tF3 += anzahl;
				}
				if (getLand == 64) {
					tF4 += anzahl;
				}
				if (getLand == 65) {
					tF5 += anzahl;
				}
				if (getLand == 66) {
					tF6 += anzahl;
				}
				if (getLand == 67) {
					tF7 += anzahl;
				}
				if (getLand == 68) {
					tF8 += anzahl;
				}
				if (getLand == 71) {
					tG1 += anzahl;
				}
				if (getLand == 72) {
					tG2 += anzahl;
				}

				if (getLand == 73) {
					tG3 += anzahl;
				}
				if (getLand == 74) {
					tG4 += anzahl;
				}
				if (getLand == 75) {
					tG5 += anzahl;
				}
				if (getLand == 76) {
					tG6 += anzahl;
				}
				if (getLand == 77) {
					tG7 += anzahl;
				}
				if (getLand == 78) {
					tG8 += anzahl;
				}
				if (getLand == 81) {
					tH1 += anzahl;
				}
				if (getLand == 82) {
					tH2 += anzahl;
				}
				
				if (getLand == 83) {
					tH3 += anzahl;
				}
				if (getLand == 84) {
					tH4 += anzahl;
				}
				if (getLand == 85) {
					tH5 += anzahl;
				}
				if (getLand == 86) {
					tH6 += anzahl;
				}
				if (getLand == 87) {
					tH7 += anzahl;
				}
				if (getLand == 88) {
					tH8 += anzahl;
				}
                if (getLand == -12110)
                {
                    tmIm11 += anzahl;
                }
                if (getLand == 12290)
                {
                    tmI29 += anzahl;
                }
                if (getLand == -103)
                {
                    tmJ3 += anzahl;
                }
                if (getLand == -104)
                {
                    tmJ4 += anzahl;
                }
                if (getLand == -105)
                {
                    tmJ5 += anzahl;
                }
                if (getLand == -10100)
                {
                    tmJm10 += anzahl;
                }
                if (getLand == -10110)
                {
                    tmJm11 += anzahl;
                }
                if (getLand == -1028)
                {
                    tmJ28 += anzahl;
                }
                if (getLand == -1029)
                {
                    tmJ29 += anzahl;
                }
                     if (getLand == -112)
                {
                    tmK2 += anzahl;
                }
                if (getLand == -113)
                {
                    tmK3 += anzahl;
                }
                if (getLand == -114)
                {
                    tmK4 += anzahl;
                }
                if (getLand == -115)
                {
                    tmK5 += anzahl;
                }
                if (getLand == -116)
                {
                    tmK6 += anzahl;
                }
                if (getLand == -1190)
                {
                    tmKm9 += anzahl;
                }
                if (getLand == -11100)
                {
                    tmKm10 += anzahl;
                }
                if (getLand == -11110)
                {
                    tmKm11 += anzahl;
                }
                if (getLand == -1127)
                {
                    tmK27 += anzahl;
                }
                if (getLand == -1128)
                {
                    tmK28 += anzahl;
                }
                if (getLand == -1129)
                {
                    tmK29 += anzahl;
                }
                if (getLand == 1829)
                {
                    tR29 += anzahl;
                }
                if (getLand == 18110)
                {
                    tRm11 += anzahl;
                }
                if (getLand == 193)
                {
                    tS3 += anzahl;
                }
                if (getLand == 194)
                {
                    tS4 += anzahl;
                }
                if (getLand == 195)
                {
                    tS5 += anzahl;
                }
                if (getLand == 1928)
                {
                    tS28 += anzahl;
                }
                if (getLand == 1929)
                {
                    tS29 += anzahl;
                }
                if (getLand == 19100)
                {
                    tSm10 += anzahl;
                }
                if (getLand == 19110)
                {
                    tSm11 += anzahl;
                }
                if (getLand == 202)
                {
                    tT2 += anzahl;
                }
                if (getLand == 203)
                {
                    tT3 += anzahl;
                }
                if (getLand == 204)
                {
                    tT4 += anzahl;
                }
                if (getLand == 205)
                {
                    tT5 += anzahl;
                }
                if (getLand == 206)
                {
                    tT6 += anzahl;
                }
                if (getLand == 2027)
                {
                    tT27 += anzahl;
                }
                if (getLand == 2028)
                {
                    tT28 += anzahl;
                }
                if (getLand == 2029)
                {
                    tT29 += anzahl;
                }
                if (getLand == 20100)
                {
                    tTm10 += anzahl;
                }
                if (getLand == 20110)
                {
                    tTm11 += anzahl;
                }


                a.ausbilden = 0;
			Debug.Log ("ausbilden = 0");
			getLand = 0;
				Truppen (anzahl);
			anzahl = 0;
			}
		}
	}
	public void Truppen(int truppen) {
		if (e.anDerReihe == 1) {
			e.truppen1 += truppen;
		}
		if (e.anDerReihe == 2) {
			e.truppen2 += truppen;
		}
		if (e.anDerReihe == 3) {
			e.truppen3 += truppen;
		}
		if (e.anDerReihe == 4) {
			e.truppen4 += truppen;
		}

	}
}

