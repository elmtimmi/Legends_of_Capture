using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
//
//
/// <summary>
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// hafen minus schiff geht nicht 
///
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// 
/// </summary>
public class hafensteeg : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	//public int los;
	int los1;
	public GameObject Hafen;
	private hafen b;
	public GameObject AngriffVerschiebung;
	private AngriffS d;//LandA1 == 1 dann setze
	private ATruppen e;
	//int Land;
    public int schiffe;
    public int land;
    public int darfbauen;
    public GameObject schiffSpawnpointA;
    private schiffspawnpoint c;
    public GameObject spawnPointa;
    private spawnPoint f;

    //public GameObject spawnPointa;
    //private spawnPoint c;
    // Use this for initialization
    void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		b = Hafen.GetComponent<hafen> ();
        c = schiffSpawnpointA.GetComponent<schiffspawnpoint>();
        d = AngriffVerschiebung.GetComponent<AngriffS> ();
		e = AngriffVerschiebung.GetComponent<ATruppen> ();
        f = spawnPointa.GetComponent<spawnPoint>();
        darfbauen = 1;
        land = f.landnummer;

	}
    void OnMouseDown()
    {
        Debug.Log("hafen");
        if (a.getland != 0)
        {
            if (a.getland == b.land)
            {
                if (a.getland != 0)
                {
                    land = a.getland;
                }
                Debug.Log("länder sind gleich");
                if (a.hafen != 0)
                {
                    if (darfbauen == 1)
                    {
                        a.schiffe = schiffe;

                        los1 = 1;
                        // b.schiffe = schiffe
                    }
                }
            }
        }
        if (d.angriff == 1)
        {
                if (darfbauen == 1)
                {
                    a.getland = land;
                Debug.Log("getland = " + a.getland);
                    a.schiffe = schiffe;
                if (a.schiffland == land)
                {
                    c.zurück = 1;
                }else
                {
                    c.zurück = 2;
                }
                Debug.Log("zurück");
                }

        }
    }
	// Update is called once per frame
	void Update () {
        if(schiffe < 0)
        {
            schiffe = 0;
        }
        if(a.schiffistda == 1)
        {
            if(a.getland == land)
            {
                schiffe++;
                a.schiffistda = 0;
            }
        }
        if (land != 0)
        {
            if (a.hafenminusschiff == land)
            {
                darfbauen = 0;
                schiffe -= 1;
                a.hafenminusschiff = 0;
                Debug.Log("hafenminusschiff");
            }
        }
        if(schiffe == 0)
        {
            darfbauen = 1;
        }
        if (a.getland == b.land)
        {
        //    Debug.Log(schiffe);
        }
            if (Input.GetKeyDown (KeyCode.F)) {
			los1 = 0;
		}
		if (a.f == 0) {
			los1 = 0;
		}
		if (los1 == 1) {
            a.los = 1;
            if (a.schiffe != 0)
            {
                schiffe = a.schiffe;
            }
        }
	}
}
