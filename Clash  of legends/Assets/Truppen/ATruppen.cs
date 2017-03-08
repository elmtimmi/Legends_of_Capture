using UnityEngine;
using System.Collections;

public class ATruppen : MonoBehaviour {
	public int aTruppen;
	public int vTruppen;
	public int gTruppen; //Truppen der Angreifer die übrigbleiben, 3 damit neutrale Zahl
	public int aGewonnen;// wenn aGewonnen = 2 hat der Verteidiger gewonnen
	public GameObject AngriffVerschiebung;
	private AngriffS a;
	public int vhatgewonnen;//für die schrift Vgewonnen
	public GameObject Verschiebung;
	private VerschiebenS b;
	public GameObject RotDran;
	private Rotistdran c;
	int einmal;
	int truppenz1;
	int truppenz2;
	int truppenz3;
	int truppenz4;
	int einmal1;
    

	
	// Use this for initialization
	void Start () {
		a = AngriffVerschiebung.GetComponent<AngriffS> ();
		b = Verschiebung.GetComponent<VerschiebenS> ();
		c = RotDran.GetComponent<Rotistdran> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (a.angriff == 1) {
			if (vTruppen != 0) {
				if (vTruppen == -1) {
					if (aTruppen == -1) {
						vTruppen = 0;
						aGewonnen = 1;
						aTruppen = 0;
					} else
					aGewonnen = 1;
					vTruppen = 0;
					gTruppen = aTruppen;
				} else if (vTruppen > 0) {
					if (aTruppen == -1) {
						aGewonnen = 0;
						vTruppen = 0;
						aTruppen = 0;
					}
				}
			          
			} 
			
			if (vTruppen != 0) {
				Debug.Log ("vTruppen = " + vTruppen);
				if(c.anDerReihe == 1){
					truppenz1 = vTruppen;
				}
				if(c.anDerReihe == 2){
					truppenz2 = vTruppen;
				}
				if(c.anDerReihe == 3){
					truppenz3 = vTruppen;
				}
				if(c.anDerReihe == 4){
					truppenz4 = vTruppen;
				}
				gTruppen = aTruppen - vTruppen;
				if (gTruppen > 0) {
					aGewonnen = 1;
					c.truppenz1 += truppenz1;
					c.truppenz2 += truppenz2;
					c.truppenz3 += truppenz3;
					c.truppenz4 += truppenz4;

					Debug.Log ("aGewonnen  ");
				} else if (gTruppen <= 0) {
					if(truppenz1 != 0){
					c.truppenz1 += (truppenz1 + gTruppen);
					}
					if(truppenz2 != 0){
					c.truppenz2 += (truppenz2 + gTruppen);
					}
					if(truppenz3 != 0){
					c.truppenz3 += (truppenz3 + gTruppen);
					}
					if(truppenz4 != 0){
					c.truppenz4 += (truppenz4 + gTruppen);
					}
					aGewonnen = 2;	
					vhatgewonnen = 1;
					Debug.Log ("vGewonnen ");
					aTruppen = 0;
				}
			}
		} else {
			if(b.verschieben != 1){
			aTruppen = 0;
			}
			}
		

		if(b.verschieben == 1){
			gTruppen = aTruppen + vTruppen;
		}
	
		
	

		if (c.f == 0) {
			vTruppen = 0;
			gTruppen = 0; 
			aGewonnen = 0;
			aTruppen = 0;
			vhatgewonnen = 0;
			einmal = 0;
			aGewonnen = 0;
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			vTruppen = 0;
			gTruppen = 0; 
			aGewonnen = 0;
			aTruppen = 0;
			vhatgewonnen = 0;
			einmal = 0;
			aGewonnen = 0;
		}
		if(aGewonnen == 1){
			Debug.Log ("agewonnen");
			if(einmal == 0){
				if(c.anDerReihe == 1){
					c.Länder1 ++;
				}
				if(c.anDerReihe == 2){
					c.Länder2 ++;
				}
				if(c.anDerReihe == 3){
					c.Länder3 ++;
				}
				if(c.anDerReihe == 4){
					c.Länder4 ++;
				}
				einmal = 1;
				}
			}
	}

}
