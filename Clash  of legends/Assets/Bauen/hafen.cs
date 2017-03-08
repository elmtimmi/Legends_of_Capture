using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hafen : MonoBehaviour {
	public GameObject elfKasernePrefab;
	public Transform spawnPoint;
	public Transform Drehung2;
	public GameObject spawnPointa;
	private spawnPoint a;
	public int abriss;	
	int einmal;
	public GameObject RotDran;
	private Rotistdran b;
	public int land;
	public int drehung;
	public int schiffe;
	// Use this for initialization
	void Start () {
		a = spawnPointa.GetComponent<spawnPoint > ();
		b = RotDran.GetComponent<Rotistdran> ();
	}
    // Update is called once per frame
    void Update()
    {
        if (b.schiffok == 1)
        {
            schiffe = b.schiffe;
            b.schiffok = 0;
        }
        if (b.getland == land)
        {
            if (b.getland != 0)
            {
                Debug.Log("drehung = " + drehung);
                a.hafendrehung = drehung;
                b.loshafen = 1;
            }
        }
        if (b.start == 1)
        {
            if (a.hafen == 1)
            {
                if (a.bZahl == 0)
                {
                    a.c3 = 1000;
                    a.v3 = 100000;
                }
                //transform.Rotate(0,0,0);
                b.schiffe = schiffe;
                land = a.landnummer;
                Debug.Log("Landnummmer = " + a.landNummer);
                Debug.Log("Land = " + land);
                drehung = a.hafendrehung;
                Instantiate(elfKasernePrefab, new Vector3(a.c3 - 110, 55f, a.v3 + 27), spawnPoint.rotation);
                Debug.Log(a.bZahl + a.bBustabe);
                a.hafen = 0;
                a.hafendrehung = 0;
            }
            if (b.hafenminusschiff == land)
            {
                if (schiffe != 0)
                {
                    Debug.Log("schiff --");
                    schiffe--;
                    b.hafenminusschiff = 0;
                }
            }
        }
    }
}
