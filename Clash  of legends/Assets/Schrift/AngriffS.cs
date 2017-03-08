using UnityEngine;
using System.Collections;

public class AngriffS : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	public GameObject Verschiebung;
	private VerschiebenS b;
	public int angriff = 0;
	public int Land1 = 1; //Land1 zum unterscheiden von angrgrifen werden oder nicht 1 = ausgangsland

	public int Landa;
	public int Landv;
	public int angreiferm;
	Rect butRect;
	float ctrlWidh = 160;
	float ctrlHight = 30;
	public int spezAngriff;
	int einmal;
	int landnummer;
    public int darfverschieben;
    public Vector3 verschieben;
    int einmala;
    int einmalb;


    void OnMouseDown(){
		angriff = 1;
		a.darfnochwasmachen = 0;
	}

	 
	// Use this for initialization
	void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		b = Verschiebung.GetComponent<VerschiebenS> ();
		GetComponent<Renderer> ().enabled = false;
	}
	void OnGUI(){
		if (a.stamm == 3) {
			if (angriff == 1) {
				if (a.coints > 2) {
					butRect = new Rect ((Screen.width - ctrlWidh) - 80, 0, ctrlWidh + 70, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 4;
					if (GUI.Button (butRect, "Truppen halbieren für 3 Rubine")) {
						if (a.coints > 2) {
							if(a.anDerReihe == 1){
								a.spez1 ++;
							}
							if(a.anDerReihe == 2){
								a.spez2 ++;
							}
							if(a.anDerReihe == 3){
								a.spez3 ++;
							}
							if(a.anDerReihe == 4){
								a.spez4 ++;
							}
							if (a.anDerReihe == 1) {
								a.rotCoints -= 3;
							}
							if (a.anDerReihe == 2) {
								a.blauCionts -= 3;
							}
							if (a.anDerReihe == 3) {
								a.grünCoints -= 3;
							}
							if (a.anDerReihe == 4) {
								a.gelbCoints -= 3;
							}
							angriff = 2;
						}
					}
				}
			}
		}
		if (a.stamm == 4) {
			if (angriff == 1) {
				if (a.coints > 2) {
					butRect = new Rect ((Screen.width - ctrlWidh) - 80, 0, ctrlWidh + 70, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 4;
					if (einmal == 0) {
						if (GUI.Button (butRect, "Truppen beschwören für 3 Rubine")) {
							if (a.coints > 2) {
								if(a.anDerReihe == 1){
									a.spez1 ++;
								}
								if(a.anDerReihe == 2){
									a.spez2 ++;
								}
								if(a.anDerReihe == 3){
									a.spez3 ++;
								}
								if(a.anDerReihe == 4){
									a.spez4 ++;
								}
								einmal = 1;
								if (a.anDerReihe == 1) {
									a.rotCoints -= 3;
								}
								if (a.anDerReihe == 2) {
									a.blauCionts -= 3;
								}
								if (a.anDerReihe == 3) {
									a.grünCoints -= 3;
								}
								if (a.anDerReihe == 4) {
									a.gelbCoints -= 3;
								}
								spezAngriff = 1;
							}
						}
					}
				}
			}
		}
		if (a.stamm == 2) {
			if (angriff == 1) {
				if (a.coints > 2) {
					butRect = new Rect ((Screen.width - ctrlWidh) - 80, 0, ctrlWidh + 70, ctrlHight);
					butRect.y = (Screen.height - ctrlHight) / 4;
					if (einmal == 0) {
						if (GUI.Button (butRect, "Grabsteine setzen für 3 Rubine")) {
							spezAngriff = 2;
							einmal = 1;
							if(a.anDerReihe == 1){
								a.spez1 ++;
							}
							if(a.anDerReihe == 2){
								a.spez2 ++;
							}
							if(a.anDerReihe == 3){
								a.spez3 ++;
							}
							if(a.anDerReihe == 4){
								a.spez4 ++;
							}
							if (a.anDerReihe == 1) {
								a.rotCoints -= 3;
							}
							if (a.anDerReihe == 2) {
								a.blauCionts -= 3;
							}
							if (a.anDerReihe == 3) {
								a.grünCoints -= 3;
							}
							if (a.anDerReihe == 4) {
								a.gelbCoints -= 3;
							}
						}
					
					}
				}
			}
		}
	}
	// Update is called once per frame
	void Update () {
        if(a.schiffangriff == 1)
        {
            angriff = 1;
        }
		if (a.spielvorbei == 1) {
			angriff = 0;
		}
		if (a.start == 1) {
			if (a.map == 1) {
			//	Vector3 temp = new Vector3 (179f, 450, 230);
		//		this.transform.position = temp;
			}
			if (a.map == 2) {
			//	Vector3 temp = new Vector3 (264f, 650, 120f);
			//	this.transform.position = temp;
			}
			if (a.map == 3) {
			//	Vector3 temp = new Vector3 (264f, 650, 120f);
			//	this.transform.position = temp;
			}
			if (a.map == 4) {
				//Vector3 temp = new Vector3 (264f, 650, 120f);
			//	this.transform.position = temp;
			}
            if (a.darfnochwasmachen == 0)
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
            if (a.darfnochwasmachen == 1) {
			GetComponent<Renderer> ().enabled = true;
		} else {
			GetComponent<Renderer> ().enabled = false;
		} 
		if (a.f == 0){
			angriff = 0;
				einmal = 0;

		}
		if (Input.GetKeyDown (KeyCode.F)) {
			angriff = 0;
				einmal = 0;

		}
		if (angriff > 0) {
			if (Landa == 0) {
				Landa = 1;
			}
			if (Landa == 2) {
				Landv = 1;
			
			}
		} else if (b.verschieben == 1) {
			if (Landa == 0) {
			Landa = 3;
			}
			if (Landa == 4) {
				if(Landv < 4){
			Landv = 4;
			}
			}
		}
		if (angriff == 0) {
			if (b.verschieben  == 0) {
			Landa = 0;
			Landv = 0;
			}
			}
		}
 	}
}



