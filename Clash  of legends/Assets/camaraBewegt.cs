using UnityEngine;
using System.Collections;

public class camaraBewegt : MonoBehaviour {
	public GameObject wieVieleSpieler;
	private wieVieleSpielerS a;
	public GameObject regelnHintergrund;
	private regelnHintergrundS b;
	public GameObject RotDran;
	private Rotistdran c;

	int kamerahatsichbewegt;
	public int hatsichbewegt;
	float ctrlWidh = 160;
	float ctrlHight = 30;
	Rect butRect;
    //wenn position == 1 dann ist es oben der rest im Uhrzeigersinn
    public int position;
	// Use this for initialization
	void Start () {

		Vector3 temp = new Vector3(10000f, 15f,10000f);
		this.transform.position = temp;
		a = wieVieleSpieler.GetComponent<wieVieleSpielerS> ();
		b = regelnHintergrund.GetComponent<regelnHintergrundS> ();
		c = RotDran.GetComponent<Rotistdran> ();
	}
    void OnGUI()
    {
        if (b.regeln == 1)
        {
            butRect = new Rect((Screen.width - ctrlWidh) + 100, 0, 50, ctrlHight);
            butRect.y = (Screen.height - ctrlHight) / 2 - 50;
            if (GUI.Button(butRect, "Oben"))
            {
                Debug.Log("Du bewegst dich nach vorne");
                var Geschwindigkeit = 1000f;
                var Richtung = new Vector3(0f, 0f, 1f);
                hatsichbewegt = 1;
                this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
            }
            butRect.y = (Screen.height - ctrlHight) / 2;
            if (GUI.Button(butRect, "Unten"))
            {
                Debug.Log("Du bewegst dich nach hinten");
                var Geschwindigkeit = 1000f;
                var Richtung = new Vector3(0f, 0f, -1f);
                hatsichbewegt = 1;
                this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
            }
        }
        if (c.start == 1)
        {
            if (hatsichbewegt == 0)
            {
                if (c.map == 4)
                {
                    if (position == 0 || position == 3 || position == 4 || position == 5)
                    {
                        butRect = new Rect(50, 50, 30, ctrlHight);
                        if (GUI.Button(butRect, " "))
                        {
                            if (position == 0)
                            {
                                position = 8;
                            }
                            else
                            if (position == 3)
                            {
                                position = 1;
                            }
                            else
                            if (position == 4)
                            {
                                position = 0;
                            }
                            else
                            if (position == 5)
                            {
                                position = 7;
                            }
                        }
                    }
                    //butRect = new Rect((Screen.width - ctrlWidh) / 2 - 100, 0, ctrlWidh, ctrlHight);
                    if (position < 6)
                    {
                        butRect = new Rect(50, (Screen.height - ctrlHight) / 2, 30, ctrlHight);
                        if (GUI.Button(butRect, " "))
                        {
                            if (position == 0)
                            {
                                position = 7;
                            }
                            else
                            if (position == 1)
                            {
                                position = 8;
                            }
                            else
                            if (position == 2)
                            {
                                position = 1;
                            }
                            else
                            if (position == 3)
                            {
                                position = 0;
                            }
                            else
                            if (position == 4)
                            {
                                position = 5;
                            }
                            else
                            if (position == 5)
                            {
                                position = 6;
                            }

                        }

                    }
                    if (position < 4)
                    {
                        butRect = new Rect(50, (Screen.height - ctrlHight) - 50, 30, ctrlHight);
                        if (GUI.Button(butRect, " "))
                        {
                            if (position == 0)
                            {
                                position = 6;
                            }
                            else
                            if (position == 1)
                            {
                                position = 7;
                            }
                            else
                            if (position == 2)
                            {
                                position = 0;
                            }
                            else
                            if (position == 3)
                            {
                                position = 5;
                            }

                        }
                    }
                    if (position == 4 || position == 5 || position == 6)
                    {

                    }
                    else
                    {
                        butRect = new Rect((Screen.width - ctrlWidh) / 2, (Screen.height - ctrlHight) - 50, 30, ctrlHight);
                        if (GUI.Button(butRect, " "))
                        {
                            if (position == 0)
                            {
                                position = 5;
                            }
                            else
                            if (position == 1)
                            {
                                position = 0;
                            }
                            else
                            if (position == 2)
                            {
                                position = 3;
                            }
                            else
                            if (position == 3)
                            {
                                position = 4;
                            }
                            else
                            if (position == 7)
                            {
                                position = 6;
                            }
                            else
                            if (position == 8)
                            {
                                position = 7;
                            }
                        }
                    }
                    if (position == 0 || position == 1 || position == 7 || position == 8)
                    {
                        butRect = new Rect((Screen.width - ctrlWidh) + 50, (Screen.height - ctrlHight) - 50, 30, ctrlHight);
                        if (GUI.Button(butRect, " "))
                        {
                            if (position == 0)
                            {
                                position = 4;
                            }
                            else
                            if (position == 1)
                            {
                                position = 3;
                            }
                            else
                            if (position == 7)
                            {
                                position = 5;
                            }
                            else
                            if (position == 8)
                            {
                                position = 0;
                            }
                        }
                    }
                    if (position == 0 || position == 1 || position > 4)
                    {
                        butRect = new Rect((Screen.width - ctrlWidh) + 50, (Screen.height - ctrlHight) / 2, 30, ctrlHight);
                        if (GUI.Button(butRect, " "))
                        {
                            if (position == 0)
                            {
                                position = 3;

                            }
                            else
                            if (position == 1)
                            {
                                position = 2;
                            }
                            else
                            if (position == 5)
                            {
                                position = 4;
                            }
                            else
                            if (position == 6)
                            {
                                position = 5;
                            }
                            else
                            if (position == 7)
                            {
                                position = 0;
                            }
                            else
                            if (position == 8)
                            {
                                position = 1;
                            }
                        }
                    }
                    if (position == 0 || position == 5 || position == 6 || position == 7)
                    {
                        butRect = new Rect((Screen.width - ctrlWidh) + 50, 50, 30, ctrlHight);
                        if (GUI.Button(butRect, " "))
                        {
                            if (position == 0)
                            {
                                position = 2;
                            }
                            else
                            if (position == 5)
                            {
                                position = 3;
                            }
                            else
                            if (position == 6)
                            {
                                position = 0;
                            }
                            else
                            if (position == 7)
                            {
                                position = 1;
                            }
                        }

                    }
                    if (position == 1 || position == 2 || position == 8)
                    {

                    }
                    else
                    {
                        butRect = new Rect((Screen.width - ctrlWidh) / 2, 50, 30, ctrlHight);
                        if (GUI.Button(butRect, " "))
                        {

                            if (position == 0)
                            {
                                position = 1;
                            }
                            else
                            if (position == 3)
                            {
                                position = 2;
                            }
                            else
                            if (position == 4)
                            {
                                position = 3;
                            }
                            else
                            if (position == 5)
                            {
                                position = 0;
                            }
                            else
                            if (position == 6)
                            {
                                position = 7;
                            }
                            else
                            if (position == 7)
                            {
                                position = 8;
                            }
                        }
                    }
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		if (a.spieler != 0) {
			if (c.start == 0) {
				if (c.map == 1) {
					Vector3 temp = new Vector3 (215f, 500, 210);
					this.transform.position = temp;
				}
				if (c.map == 2) {
					Vector3 temp = new Vector3 (300f, 700, 100);
					this.transform.position = temp;
				}
			}
		}
		if (a.spieler == 0) {
			if (b.regeln == 1) {
				if (kamerahatsichbewegt == 0) {
					Vector3 temp = new Vector3 (-10000f, 20f, -10000f);
					this.transform.position = temp;
					kamerahatsichbewegt = 1;
				}
			} else {
				Vector3 temp = new Vector3 (10000f, 15f, 10000f);
				this.transform.position = temp;
				kamerahatsichbewegt = 0;
				hatsichbewegt = 0;

			}

		} else {
			if (a.spieler > 0) {
				if (kamerahatsichbewegt < 2) {
					Vector3 temp = new Vector3 (215f, 500f, 210f);
					this.transform.position = temp;
					kamerahatsichbewegt = 2;
				}

			}
			if (c.start == 1) {
				if (Input.GetKey (KeyCode.RightArrow)) {
					Debug.Log ("Du bewegst dich nach rechts");
					var Geschwindigkeit = 100f;
					var Richtung = new Vector3 (1f, 0f, 0f);
			
					this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
					hatsichbewegt = 1;

				}
				if (Input.GetKey (KeyCode.LeftArrow)) {
					Debug.Log ("Du bewegst dich nach links");
					var Geschwindigkeit = 100f;
					var Richtung = new Vector3 (-1f, 0f, 0f);
			
					this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
					hatsichbewegt = 1;

				}
				if (Input.GetKey (KeyCode.Q)) {
					Debug.Log ("Du bewegst dich nach oben");
					var Geschwindigkeit = 100f;
					var Richtung = new Vector3 (0f, 1f, 0f);
			
					this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
					hatsichbewegt = 1;
			
				}
				if (Input.GetKey (KeyCode.Y)) {
					Debug.Log ("Du bewegst dich nach unten");
					var Geschwindigkeit = 100f;
					var Richtung = new Vector3 (0f, -1f, 0f);
			
					this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
					hatsichbewegt = 1;
			
				}
	
				if (Input.GetKey (KeyCode.P)) {
					hatsichbewegt = 0;
					if (c.map == 1) {
						Vector3 temp = new Vector3 (215f, 500, 210);
						this.transform.position = temp;
					}
					if (c.map == 2) {
						Vector3 temp = new Vector3 (300f, 700, 100);
						this.transform.position = temp;
					}
					if (c.map == 3) {
						Vector3 temp = new Vector3 (300f, 700, 100);
						this.transform.position = temp;
					}
					if (c.map == 4) {
						Vector3 temp = new Vector3 (300f, 700, 100);
						this.transform.position = temp;
					}
				}
			}
		}
			if (b.regeln == 1) {
				if (Input.GetKey (KeyCode.UpArrow)) {
					Debug.Log ("Du bewegst dich nach vorne");
					var Geschwindigkeit = 100f;
					var Richtung = new Vector3 (0f, 0f, 1f);
					hatsichbewegt = 1;
					this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
			
				}
				if (Input.GetKey (KeyCode.DownArrow)) {
					Debug.Log ("Du bewegst dich nach hinten");
					var Geschwindigkeit = 100f;
					var Richtung = new Vector3 (0f, 0f, -1f);
					hatsichbewegt = 1;
					this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
			
				}
			}
		if (c.start == 1) {
			if (Input.GetKey (KeyCode.UpArrow)) {
				Debug.Log ("Du bewegst dich nach vorne");
				var Geschwindigkeit = 100f;
				var Richtung = new Vector3 (0f, 0f, 1f);
				hatsichbewegt = 1;
				this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
				
			}
			if (Input.GetKey (KeyCode.DownArrow)) {
				Debug.Log ("Du bewegst dich nach hinten");
				var Geschwindigkeit = 100f;
				var Richtung = new Vector3 (0f, 0f, -1f);
				hatsichbewegt = 1;
				this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;
				
			}
		}
			if (c.rangliste == 1) {
				Vector3 temp = new Vector3 (-1000000f, 20f, -10000f);
				this.transform.position = temp;
			}
			if (c.statistik == 1) {
				Vector3 temp = new Vector3 (-1000000f, 20f, -10000f);
				this.transform.position = temp;
				hatsichbewegt = 1;
			}
            if(c.kameramove == 1)
        { 
            if(c.map == 1)
            {
                this.transform.position = new Vector3(c.pa.x,500, c.pa.z);
            }else
            {
                this.transform.position = new Vector3(c.pa.x, 700, c.pa.z);
            }
        }
            if(c.map == 4)
        {
            if(hatsichbewegt == 0)
            {
                if (position == 0)
                {
                    Vector3 temp = new Vector3(300f, 700, 100);
                    this.transform.position = temp;
                }
                if (position == 1)
                {
                    Vector3 temp = new Vector3(300f, 700, 1000);
                    this.transform.position = temp;
                }
                if (position == 2)
                {
                    Vector3 temp = new Vector3(1275f, 700, 1000);
                    this.transform.position = temp;
                }
                if (position == 3)
                {
                    Vector3 temp = new Vector3(1275f, 700, 25);
                    this.transform.position = temp;
                }
                if (position == 4)
                {
                    Vector3 temp = new Vector3(1275f, 700, -950);
                    this.transform.position = temp;
                }
                if (position == 5)
                {
                    Vector3 temp = new Vector3(300f, 700, -950);
                    this.transform.position = temp;
                }
                if (position == 6)
                {
                    Vector3 temp = new Vector3(-675f, 700, -950);
                    this.transform.position = temp;
                }
                if (position == 7)
                {
                    Vector3 temp = new Vector3(-675f, 700, 25);
                    this.transform.position = temp;
                }
                if (position == 8)
                {
                    Vector3 temp = new Vector3(-675f, 700, 1000);
                    this.transform.position = temp;
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            c.kameramove = 0;
        }
        if (c.f == 0)
        {
            c.kameramove = 0;
        }
    }
}
