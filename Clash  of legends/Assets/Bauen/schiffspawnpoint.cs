using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schiffspawnpoint : MonoBehaviour {
	public GameObject Ausbilden;
	private Ausbilden a;
	public GameObject RotDran;
	private Rotistdran b;
	public GameObject hafenSteeg;
	private hafensteeg c;
	public GameObject spawnPointa;
	private spawnPoint d;
	public int schiffe;
	public int c3;
	public int v3;
	int einmal;
	public int los;
    public int zurück;
    public int zurückanschiff;
	// Use this for initialization
	void Start () {
		a = Ausbilden.GetComponent<Ausbilden> ();
		b = RotDran.GetComponent<Rotistdran> ();
		c = hafenSteeg.GetComponent<hafensteeg> ();
		d = spawnPointa.GetComponent<spawnPoint > ();

		}
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.identity;
		if (b.los == 1) {
			Debug.Log ("spownt");
			schiffe = b.hafen;
           // b.getland = 41;
			v3 = (-(b.getland / 10) * 75) + 595;
			c3 = ((b.getland - b.getland / 10 *10 ) * 75) + 50;
            Debug.Log("Land =  " + b.getland/10 + "   " + (b.getland - b.getland / 10 * 10));
            Debug.Log("Landp =  " + (-(b.getland / 10) * 75) + 445);
            if (b.hafen > 0)
            {
                if (b.schiffe < 5)
                {
                    if (d.hafendrehung == 0)
                    {
                        Debug.Log("Drehung = 0");
                        c3 -= 95;
                        v3 -= 137;
                        transform.Rotate(0, -90, 0);
                        los = 1;
                        if (b.schiffe == 1)
                        {
                            v3 += 10;
                        }
                        if (b.schiffe == 2)
                        {
                            v3 += 20;
                        }
                        if (b.schiffe == 3)
                        {
                            v3 += 30;
                        }
                        if (b.schiffe == 4)
                        {
                            v3 += 40;
                        }
                        if (b.schiffe == 5)
                        {
                            v3 += 50;
                        }
                    }
                    if (d.hafendrehung == 1)
                    {
                        Debug.Log("Drehung = 1");
                        c3 -= 47;
                        v3 -= 53;
                        transform.Rotate(0, 0, 0);
                        los = 1;
                        if (b.schiffe == 1)
                        {
                            c3 += 10;
                        }
                        if (b.schiffe == 2)
                        {
                            c3 += 20;
                        }
                        if (b.schiffe == 3)
                        {
                            c3 += 30;
                        }
                        if (b.schiffe == 4)
                        {
                            c3 += 40;
                        }
                        if (b.schiffe == 5)
                        {
                            c3 += 50;
                        }
                    }
                    if (d.hafendrehung == 2)
                    {
                        Debug.Log("Drehung = 1");
                        c3 += 40;
                        v3 -= 137;
                        transform.Rotate(0, 90, 0);
                        los = 1;
                        if (b.schiffe == 1)
                        {
                            v3 += 10;
                        }
                        if (b.schiffe == 2)
                        {
                            v3 += 20;
                        }
                        if (b.schiffe == 3)
                        {
                            v3 += 30;
                        }
                        if (b.schiffe == 4)
                        {
                            v3 += 40;
                        }
                        if (b.schiffe == 5)
                        {
                            v3 += 50;
                        }
                    }
                    if (d.hafendrehung == 3)
                    {
                        Debug.Log("Drehung = 3");
                        c3 -= 47;
                        v3 -= 185;
                        transform.Rotate(0, 180, 0);
                        los = 1;
                        if (b.schiffe == 1)
                        {
                            c3 += 10;
                        }
                        if (b.schiffe == 2)
                        {
                            c3 += 20;
                        }
                        if (b.schiffe == 3)
                        {
                            c3 += 30;
                        }
                        if (b.schiffe == 4)
                        {
                            c3 += 40;
                        }
                        if (b.schiffe == 5)
                        {
                            c3 += 50;
                        }
                    }
                    if (b.schiffe < 5)
                    {
                        b.schiffe++;
                    }
                    b.los = 0;
                    b.hafen--;
                    transform.position = new Vector3(c3, 0f, v3);
                    einmal = 1;
                }
            }
		}
        if (zurück > 0)
        {
            if (b.schiffe < 5)
            {
                if (b.getland != 0)
                {
                    if (b.loshafen == 1)
                    {
                        v3 = (-(b.getland / 10) * 75) + 595;
                        c3 = ((b.getland - b.getland / 10 * 10) * 75) + 50;
                        Debug.Log("Land =  " + b.getland / 10 + "   " + (b.getland - b.getland / 10 * 10));
                        Debug.Log("Landp =  " + (-(b.getland / 10) * 75) + 445);
                        if (d.hafendrehung == 0)
                        {
                            Debug.Log("Drehung = 0");
                            c3 -= 95;
                            v3 -= 137;
                            transform.Rotate(0, -90, 0);
                            if (b.schiffe == 1)
                            {
                                v3 += 10;
                            }
                            if (b.schiffe == 2)
                            {
                                v3 += 20;
                            }
                            if (b.schiffe == 3)
                            {
                                v3 += 30;
                            }
                            if (b.schiffe == 4)
                            {
                                v3 += 40;
                            }
                            if (b.schiffe == 5)
                            {
                                v3 += 50;
                            }
                        }
                        if (d.hafendrehung == 1)
                        {
                            Debug.Log("Drehung = 1");
                            c3 -= 47;
                            v3 -= 53;
                            transform.Rotate(0, 0, 0);
                            if (b.schiffe == 1)
                            {
                                c3 += 10;
                            }
                            if (b.schiffe == 2)
                            {
                                c3 += 20;
                            }
                            if (b.schiffe == 3)
                            {
                                c3 += 30;
                            }
                            if (b.schiffe == 4)
                            {
                                c3 += 40;
                            }
                            if (b.schiffe == 5)
                            {
                                c3 += 50;
                            }
                        }
                        if (d.hafendrehung == 2)
                        {
                            Debug.Log("Drehung = 1");
                            c3 += 40;
                            v3 -= 137;
                            transform.Rotate(0, 90, 0);
                            if (b.schiffe == 1)
                            {
                                v3 += 10;
                            }
                            if (b.schiffe == 2)
                            {
                                v3 += 20;
                            }
                            if (b.schiffe == 3)
                            {
                                v3 += 30;
                            }
                            if (b.schiffe == 4)
                            {
                                v3 += 40;
                            }
                            if (b.schiffe == 5)
                            {
                                v3 += 50;
                            }
                        }
                        if (d.hafendrehung == 3)
                        {
                            Debug.Log("Drehung = 3");
                            c3 -= 47;
                            v3 -= 185;
                            transform.Rotate(0, 180, 0);
                            if (b.schiffe == 1)
                            {
                                c3 += 10;
                            }
                            if (b.schiffe == 2)
                            {
                                c3 += 20;
                            }
                            if (b.schiffe == 3)
                            {
                                c3 += 30;
                            }
                            if (b.schiffe == 4)
                            {
                                c3 += 40;
                            }
                            if (b.schiffe == 5)
                            {
                                c3 += 50;
                            }
                        }
                        zurück = 0;
                        Debug.Log("schiff zurück");
                        transform.position = new Vector3(c3, 0f, v3);
                        zurückanschiff = 1;
                        b.loshafen = 0;
                    }
                }
            }
        }
		if (Input.GetKeyDown (KeyCode.F)) {
			einmal = 0;
            zurückanschiff = 0;
		}
		if (b.f == 0) {
			einmal = 0;
            zurückanschiff = 0;
        }
	}
}
