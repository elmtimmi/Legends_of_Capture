using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schiffS : MonoBehaviour {

	public GameObject HafenPrefab;
	public Transform schiffSpawnpoint;
	public Transform Drehung2;
	public GameObject spawnPointa;
	private spawnPoint a;
	public int abriss;	
	public GameObject RotDran;
	private Rotistdran b;
	public GameObject schiffSpawnpointA;
	private schiffspawnpoint c;
	public int farbe;
	public int truppen;
	public GameObject AngriffVerschiebung;
	private AngriffS d;//LandA1 == 1 dann setze
	private ATruppen e;
	public int Land;
	public Vector3 size;
	public int hafen;
	int radius;
    int land;
	public int imbereich;
    private Vector3 newPosition;
    public int habemichbewegt;
    public int darfzumhafen;
    int einmal;
    public float rotation;
    void Start() {
		BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
			b = RotDran.GetComponent<Rotistdran> ();
			a = spawnPointa.GetComponent<spawnPoint > ();
			c = schiffSpawnpointA.GetComponent<schiffspawnpoint> ();
			d = AngriffVerschiebung.GetComponent<AngriffS> ();
			e = AngriffVerschiebung.GetComponent<ATruppen> ();
		boxCollider.size = new Vector3(6,80, 30);
		hafen = 1;
        farbe = b.anDerReihe;

    }

	void OnMouseDown(){
		b.p = transform.position;
        b.schifftruppen = truppen;
		Debug.Log ("Truppen = " + truppen);
		if (d.Landa == 3) {
			e.aTruppen = 0;
            land = 3;
			d.Landa = 4;
		} else if (d.Landv == 4) {
            land = 4;
            if (b.schiffeverschiebung < 2)
            {
                d.Landv = 5;
            }
		}
		if (Land > 2) {
			if (radius == 0) {
			//	b.p = transform.position;
			} else {
				b.p = new Vector3 (1000, 1000, 1000);
			}
		}
        if (d.angriff == 1)
        {
            if (farbe == b.anDerReihe)
            {
                if (habemichbewegt == 0)
                {
                    e.aTruppen = truppen;
                    b.schiffangriff = 1;
                    c.zurück = 0;
                    c.zurückanschiff = 0;
                    b.pa = transform.position;
                        darfzumhafen = 1;
                    b.schiffland = Land;
                    d.Landv = 1;
                    //Wenn land angraifen dann auf land klicken
                    Debug.Log("schiffangriff bereit");
                }
            }
        }
    }
	// Update is called once per frame
	void Update () {
        rotation = transform.rotation.y;

        if (einmal == 0)
        {
            if (b.landerobert == Land)
            {
                if (Land != 0)
                {
                    if (rotation < 0)
                    {
                        this.transform.position += new Vector3(-50, 0, 0);
                        Debug.Log("bewegt");
                    }
                    else
                      if (rotation == 1)
                    {
                        this.transform.position += new Vector3(0, 0, -50);
                    }
                    else
                      if (rotation > 0)
                    {
                        this.transform.position += new Vector3(50, 0, 0);
                    }
                    if (rotation == 0)
                    {
                        this.transform.position += new Vector3(0, 0, 50);
                    }
                    einmal = 1;
                    Land = 0;
                }
            }
        }
        if (habemichbewegt == 0)
        {
            if (c.zurückanschiff == 1)
            {
                if (darfzumhafen == 1)
                {
                    //getfarbe muss noch gesetzt werden, beim zurück
                    this.transform.position = c.transform.position;
                    this.transform.rotation = c.transform.rotation;
                    darfzumhafen = 0;
                    c.zurückanschiff = 0;
                    habemichbewegt = 1;
                    b.p = new Vector3(1000, 1000, 1000);
                    b.pa = new Vector3(1000, 1000, 1000);
                    b.kameramove = 0;
                    b.schiffistda = 1;
                    hafen = 1;
                    Land = b.getland;
                    d.Landv = 5;
                    // Debug.Log("land = " + b.getland);
                }
            }
        }
        if (habemichbewegt == 0)
        {
            if (darfzumhafen == 1)
            {
                if (b.angreifen == 1)
                {
                    d.Landv = 5;
                    truppen = 0;
                    b.angreifen = 0;
                    b.kameramove = 0;
                    b.pa = new Vector3(1000, 1000, 1000);
                    b.p = new Vector3(1000, 1000, 1000);
                    habemichbewegt = 1;
                }
            }
        }
        if(habemichbewegt == 0) {
            if (farbe == b.anDerReihe)
            {
                if ( b.pa == transform.position)
        {
            b.kameramove = 1;
            if(d.darfverschieben == 2)
            {
                        if (Input.GetMouseButtonDown(0))
                        {
                            RaycastHit hit;
                            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                            if (Physics.Raycast(ray, out hit))
                            {
                                newPosition = hit.point;
                                transform.position = new Vector3(newPosition.x, transform.position.y, newPosition.z);
                                Debug.Log("habemichbewegt");
                                d.darfverschieben = 0;
                                b.kameramove = 0;
                                habemichbewegt = 1;
                                b.pa = new Vector3(1000, 1000, 1000);
                                b.p = new Vector3(1000, 1000, 1000);
                                if(hafen == 1)
                                {
                                    b.hafenminusschiff = Land;
                                }
                                hafen = 0;
                                Debug.Log(b.hafenminusschiff);
                                d.Landa = 4;
                                Land = 0;
                            }
                        }
                    }
            }
        }
        }

        transform.localScale = new Vector3(1, 1, 1);
		if (Input.GetKeyDown (KeyCode.F)) {
			b.los = 0;
            habemichbewegt = 0;
		}
		if (b.f == 0) {
			b.los = 0;
            habemichbewegt = 0;
        }
	//	if (a.hafen == 1) {
			//Instantiate (HafenPrefab, new Vector3 (a.c3, 10f, a.v3), spawnPoint.rotation);
			//a.hafen = 0;
		//}
			if (c.los == 1) {
			Land = b.getland;
			if (b.schiffe < 6) {
				Instantiate (HafenPrefab, schiffSpawnpoint.position, schiffSpawnpoint.rotation);
				c.los = 0;
			}
		}
		if (hafen == 1) {
            //	if (Land == 3) {
            if (imbereich == 1)
            {
                if (d.Landa == 4)
                {
                    if (d.Landv == 4)
                    {
                        b.schiffeverschiebung = 3;
                            e.aTruppen += truppen;
                            truppen = 0;     
             }
                }
				//if(wird schiffradius berührt) dann " "
			}
			//if(Land == 4){
			//	if(truppen < 5){
			//	if(e.aTruppen > 0){
			//		e.aTruppen --;
			//		truppen ++;
			//	}
			//}
			//}
            if(b.schiffeverschiebung < 2) {
                if (d.Landv == 5)
                {
                    if (imbereich == 1)
                    {
                        if (e.aTruppen > 0)
                        {
                            b.schiffeverschiebung = 1;
                            if (truppen < 5)
                            {
                                Debug.Log("wurde verschoben");
                                e.aTruppen--;
                                truppen += 1;
                            }
                        }
                    }
                }
			}
		}
		float distanceSqr = (b.p - transform.position).sqrMagnitude;
		float radiusSqr = 10 * 10;

		// Gets a vector that points from the player's position to the target's.
		var heading = b.p - transform.position;

		var distance = heading.magnitude;
		var direction = heading / distance; // This is now the normalized direction.
		if (distance < 100) {
		//	Debug.Log (distance);
			imbereich = 1;
		} else {
			imbereich = 0;
		}
        if (Input.GetKeyDown(KeyCode.F))
        {
            darfzumhafen = 0;
            habemichbewegt = 0;
            einmal = 0;
        }
        if (b.f == 0)
        {
            darfzumhafen = 0;
            habemichbewegt = 0;
            einmal = 0;
        }
        }
}
