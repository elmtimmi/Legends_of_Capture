using UnityEngine;
using System.Collections;

public class map1 : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	public int anderp;
	public int darfnoch;
	public int darfnoch1; 

	// Use this for initialization
	void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		anderp = 1;
	}
	
	// Update is called once per frame
	void Update () {

	if (a.map == 1) {
			if (anderp == 1) {
				anderp = 0;
		
			} else {
				if (darfnoch1 == 1) {
						var Richtung = new Vector3 (0f, 0f, 10000f);
						this.transform.position +=  -Richtung;
					darfnoch1 = 0;
						
				}
			}
			darfnoch = 1;
		} 
		else {
			if (darfnoch == 1) {
					var Richtung = new Vector3 (0f, 0f, 10000f);
					this.transform.position += Richtung;
				darfnoch = 0;
				darfnoch1 = 1;
			}
		}

	}
}
