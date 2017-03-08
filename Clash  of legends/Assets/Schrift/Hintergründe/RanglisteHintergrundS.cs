using UnityEngine;
using System.Collections;

public class RanglisteHintergrundS : MonoBehaviour {
	public GameObject SpielVorbei;
	private SpielVorbeiS b;
	public GameObject RotDran;
	private Rotistdran a;
	float ctrlWidh = 160;
	float ctrlHight = 30;
	Rect butRect;
	// Use this for initialization
	void Start () {
		a = RotDran.GetComponent<Rotistdran> ();
		b = SpielVorbei.GetComponent<SpielVorbeiS> ();
	}
	void OnMouseDown(){
		a.rangliste = 1;
	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		if (a.rangliste == 1) {
			butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
			butRect.y = 0;
			GUI.Label (butRect, "Rangliste");
			butRect.y += 20;
			if(b.user1 != ""){
			GUI.Label (butRect, "1.: " + b.user1);
			}
			butRect.y += 20;
			if(b.user2 != ""){
			GUI.Label (butRect, "2.: " + b.user2);
			}
			butRect.y += 20;
			if(b.user3 != ""){
			GUI.Label (butRect, "3.: " + b.user3);
			}
			butRect.y += 20;
			if(b.user4 != ""){
			GUI.Label (butRect, "4.: " + b.user4);
			}
			butRect.y += 20;
			if(b.user5 != ""){
			GUI.Label (butRect, "5.: " + b.user5);
			}
			butRect.y += 20;
			if(b.user6 != ""){
			GUI.Label (butRect, "6.: " + b.user6);
			}
			butRect.y += 20;
			if(b.user7 != ""){
			GUI.Label (butRect, "7.: " + b.user7);
			}
			butRect.y += 20;
			if(b.user8 != ""){
			GUI.Label (butRect, "8.: " + b.user8);
				}
			butRect.y += 20;
			if(b.user9 != ""){
			GUI.Label (butRect, "9.: " + b.user9);
			}
			butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 50, 0, ctrlWidh, ctrlHight);
			butRect.y += 20;
			if(b.user1 != ""){
			GUI.Label (butRect, " "+  b.score1);
			}
			butRect.y += 20;
			if(b.user2 != ""){
			GUI.Label (butRect, " "+  b.score2);
			}
			butRect.y += 20;
			if(b.user3 != ""){
			GUI.Label (butRect," "+  b.score3);
			}
			butRect.y += 20;
			if(b.user4 != ""){
			GUI.Label (butRect," "+  b.score4);
			}
			butRect.y += 20;
			if(b.user5 != ""){
			GUI.Label (butRect, " "+ b.score5);
			}
			butRect.y += 20;
			if(b.user6 != ""){
			GUI.Label (butRect," "+  b.score6);
			}
			butRect.y += 20;
			if(b.user7 != ""){
			GUI.Label (butRect," "+  b.score7);
			}
			butRect.y += 20;
			if(b.user8 != ""){
			GUI.Label (butRect, " "+ b.score8);
			}
			butRect.y += 20;
			if(b.user9 != ""){
			GUI.Label (butRect," " +  b.score9);
			}
			butRect.y += 20;
		}
	}
}
