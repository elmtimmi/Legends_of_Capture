using UnityEngine;
using System.Collections;
using System.IO;

public class SpielVorbeiS : MonoBehaviour {
	public GameObject RotDran;
	private Rotistdran a;
	public GameObject wieVieleSpieler;
	private wieVieleSpielerS b;
	float ctrlWidh = 160;
	float ctrlHight = 30;
	Rect butRect;
	public int spielvorbei;
	string spieler;
	public string user;
	public string user1;
	public int score1;	
	public string user2;
	public int score2;	
	public string user3;
	public int score3;	
	public string user4;
	public int score4;	
	public string user5;
	public int score5;	
	public string user6;
	public int score6;	
	public string user7;
	public int score7;	
	public string user8;
	public int score8;	
	public string user9;
	public int score9;	
	public int myint1;
	int spielvorbei1;
	int tabelle;
	public string speicher;
	public int zahl;
	int startistik;
		// Use this for initialization
	void Start () {
		score1 = PlayerPrefs.GetInt ("score1");
		score2 = PlayerPrefs.GetInt ("score2");
		score3 = PlayerPrefs.GetInt ("score3");
		score4 = PlayerPrefs.GetInt ("score4");
		score5 = PlayerPrefs.GetInt ("score5");
		score6 = PlayerPrefs.GetInt ("score6");
		score7 = PlayerPrefs.GetInt ("score7");
		score8 = PlayerPrefs.GetInt ("score8");
		score9 = PlayerPrefs.GetInt ("score9");
		user1 = PlayerPrefs.GetString ("user1");
		user2 = PlayerPrefs.GetString ("user2");
		user3 = PlayerPrefs.GetString ("user3");
		user4 = PlayerPrefs.GetString ("user4");
		user5 = PlayerPrefs.GetString ("user5");
		user6 = PlayerPrefs.GetString ("user6");
		user7 = PlayerPrefs.GetString ("user7");
		user8 = PlayerPrefs.GetString ("user8");
		user9 = PlayerPrefs.GetString ("user9");
		a = RotDran.GetComponent<Rotistdran> ();
		b = wieVieleSpieler.GetComponent<wieVieleSpielerS> ();
		gameObject.GetComponent<Renderer> ().material.color = Color.black;
	}
	
	// Update is called once per frame
	void OnGUI(){
		if (spielvorbei == 1) {
			a.spielvorbei = 1;
			butRect = new Rect ((Screen.width - ctrlWidh) / 2 , 0, ctrlWidh, ctrlHight);
			butRect.y = (Screen.width - ctrlHight) / 2;
			if (GUI.Button (butRect, "Hauptmenu")) {
				Application.LoadLevel (1);
			}
			butRect = new Rect ((Screen.width - ctrlWidh) / 2, 0, ctrlWidh, ctrlHight);
			butRect.y = (Screen.width - ctrlHight) / 2 - 40;
			if (startistik == 0) {
				if (GUI.Button (butRect, "Statistik")) {
					a.statistik = 1;
					startistik = 1;
				}
			}
			butRect.y -= 30;
			butRect.x += 40;
			if (startistik == 0) {
				GUI.Label (butRect, spieler + " hat Gewonnen!");
			}
		}
		//	user = spieler;
		if (user1 == spieler) {
			//	user1 = user1 ;
		}
		if (a.statistik == 1) {
			butRect = new Rect ((Screen.width - ctrlWidh) / 2 -250, 0, ctrlWidh, ctrlHight);
			butRect.y = 0;
			GUI.Label (butRect, "Name :");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.username1);
			butRect.y += 20;
			GUI.Label (butRect, "" + a.username2);
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.username3);
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.username4);
			}

			butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 200, 0, ctrlWidh, ctrlHight);
			butRect.y = 0;
			GUI.Label (butRect, "Truppen ausgebildet: ");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.truppen1);
			butRect.y += 20;
			GUI.Label (butRect, "" + a.truppen2);
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.truppen3);
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.truppen4);
			}

			butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 50, 0, ctrlWidh, ctrlHight);
			butRect.y = 0;
			GUI.Label (butRect, "Truppen getötet: ");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.truppenz1);
			butRect.y += 20;
			GUI.Label (butRect, "" + a.truppenz2);
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.truppenz3);
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.truppenz4);
			}


			butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 80 ,0 , ctrlWidh, ctrlHight);
			butRect.y = 0;
			GUI.Label (butRect, "Länder eingenommen:");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.Länder1);
			butRect.y += 20;
			GUI.Label (butRect, "" + a.Länder2);
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.Länder3);
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.Länder4);
			}

			butRect = new Rect ((Screen.width - ctrlWidh) / 2 -250, 0, ctrlWidh, ctrlHight);
			butRect.y =  120;
			GUI.Label (butRect, "Name :");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.username1);
			butRect.y += 20;
			GUI.Label (butRect, "" + a.username2);
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.username3);
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.username4);
			}

			butRect = new Rect ((Screen.width - ctrlWidh) / 2 -200 ,0 , ctrlWidh, ctrlHight);
			butRect.y =  120;
			GUI.Label (butRect, "Rathäuser gewürfelt:") ;
			butRect.y += 20;
			GUI.Label (butRect, "" + a.Rathaus1  + "  (" +  ( a.Rathaus1 /(a.Rathaus1 + a.kasernen1 + a.brücken1 + a.niete1) * 100) + "%)");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.Rathaus2 + "  (" +  ( a.Rathaus2 /(a.Rathaus2 + a.kasernen2 + a.brücken2 + a.niete2) * 100) + "%)");
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.Rathaus3 + "  (" +  ( a.Rathaus3 /(a.Rathaus3 + a.kasernen3 + a.brücken3 + a.niete3) * 100) + "%)");
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.Rathaus4 + "  (" +  ( a.Rathaus4 /(a.Rathaus4 + a.kasernen4 + a.brücken4 + a.niete4) * 100) + "%)");
			}

			butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 50 ,0 , ctrlWidh, ctrlHight);
			butRect.y =  120;
			GUI.Label (butRect, "Kasernen gewürfelt:");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.kasernen1 + "  (" +  ( a.kasernen1 /(a.Rathaus1 + a.kasernen1 + a.brücken1 + a.niete1) * 100) + "%)");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.kasernen2+ "  (" +  ( a.kasernen2 /(a.Rathaus2 + a.kasernen2 + a.brücken2 + a.niete2) * 100) + "%)");
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.kasernen3+ "  (" +  ( a.kasernen3 /(a.Rathaus3 + a.kasernen3 + a.brücken3 + a.niete3) * 100) + "%)");
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.kasernen4+ "  (" +  ( a.kasernen4 /(a.Rathaus4 + a.kasernen4+ a.brücken4 + a.niete4) * 100) + "%)");
			}
			butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 100,0 , ctrlWidh, ctrlHight);
			butRect.y =  120;
			GUI.Label (butRect, "Brückengebäude gewürfelt:");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.brücken1 + "  (" +  ( a.brücken1 /(a.Rathaus1 + a.kasernen1 + a.brücken1 + a.niete1) * 100) + "%)");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.brücken2+ "  (" +  ( a.brücken2 /(a.Rathaus2 + a.kasernen2 + a.brücken2 + a.niete2) * 100) + "%)");
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.brücken3+ "  (" +  ( a.brücken3 /(a.Rathaus3 + a.kasernen3 + a.brücken3 + a.niete3) * 100) + "%)");
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.brücken4+ "  (" +  ( a.brücken4 /(a.Rathaus4 + a.kasernen4+ a.brücken4 + a.niete4) * 100) + "%)");
			}
			butRect = new Rect ((Screen.width - ctrlWidh) / 2 + 300,0 , ctrlWidh, ctrlHight);
			butRect.y =  120;
			GUI.Label (butRect, "Niete gewürfelt:");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.niete1 + "  (" +  ( a.niete1 /(a.Rathaus1 + a.kasernen1 + a.brücken1 + a.niete1) * 100) + "%)");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.niete2 + "  (" +  ( a.niete2 /(a.Rathaus2 + a.kasernen2 + a.brücken2 + a.niete2) * 100) + "%)");
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.niete3 + "  (" +  ( a.niete3 /(a.Rathaus3 + a.kasernen3 + a.brücken3 + a.niete3) * 100) + "%)");
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.niete4 + "  (" +  ( a.niete4 /(a.Rathaus4 + a.kasernen4+ a.brücken4 + a.niete4) * 100) + "%)");
			}


			butRect = new Rect ((Screen.width - ctrlWidh) / 2 -250, 0, ctrlWidh, ctrlHight);
			butRect.y = 240;
			GUI.Label (butRect, "Name :");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.username1);
			butRect.y += 20;
			GUI.Label (butRect, "" + a.username2);
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.username3);
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.username4);
			}

			butRect = new Rect ((Screen.width - ctrlWidh) / 2 - 200, 0, ctrlWidh + 100, ctrlHight);
			butRect.y = 240;
			GUI.Label (butRect, "Spezialfähigkiten Eingesetzt: ");
			butRect.y += 20;
			GUI.Label (butRect, "" + a.spez1);
			butRect.y += 20;
			GUI.Label (butRect, "" + a.spez2);
			if (b.spieler > 2) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.spez3);
			}
			if (b.spieler == 4) {
				butRect.y += 20;
				GUI.Label (butRect, "" + a.spez4);
			}
		}
	}
	void Update () {
		if(b.spieler == 4){
	if(a.rotlebt + a.blaulebt + a.gelblebt + a.grünlebt == 1){
		//	GetComponent<Renderer> ().enabled = true;
				spielvorbei  = 1;
				if(a.rotlebt == 1){
					spieler = a.username1;
				}
				if(a.blaulebt == 1){
					spieler = a.username2;
				}
				if(a.grünlebt == 1){
					spieler = a.username3;
				}
				if(a.blaulebt == 1){
					spieler = a.username4;
				}
		}else GetComponent<Renderer> ().enabled = false;
		}
		if(b.spieler == 3){
			if(a.rotlebt + a.blaulebt + a.gelblebt + a.grünlebt == 2){
			//	GetComponent<Renderer> ().enabled = true;
				spielvorbei  = 1;
				if(a.rotlebt == 1){
					spieler = a.username1;
				}
				if(a.blaulebt == 1){
					spieler = a.username2;
				}
				if(a.grünlebt == 1){
					spieler = a.username3;
				}
			}else GetComponent<Renderer> ().enabled = false;
		}
		if(b.spieler == 2){
			if(a.rotlebt + a.blaulebt + a.gelblebt + a.grünlebt == 3){
		//		GetComponent<Renderer> ().enabled = true;
				spielvorbei  = 1;
			}else GetComponent<Renderer> ().enabled = false;
			if(a.rotlebt == 1){
				spieler = a.username1;
			}
			if(a.blaulebt == 1){
				spieler = a.username2;
			}
		}
		if (spielvorbei == 1) {
			a.anDerReihe = 0;
			if(spielvorbei1 == 0){
				if(spieler != "Name"){
				if(spieler == user1){
					score1 ++;
					tabelle = 1;
				}
				if(spieler == user2){
					score2 ++;
					tabelle = 1;
				}
				if(spieler == user3){
					score3 ++;
					tabelle = 1;
				}
				if(spieler == user4){
					score4 ++;
					tabelle = 1;
				}
				if(spieler == user5){
					score5 ++;
					tabelle = 1;
				}
				if(spieler == user6){
					score6 ++;
					tabelle = 1;
				}
				if(spieler == user7){
					score7 ++;
					tabelle = 1;
				}
				if(spieler == user8){
					score8 ++;
					tabelle = 1;
				}
				if(spieler == user9){
					score9 ++;
					tabelle = 1;
				}
				if(tabelle == 0){
			if(score1 == 0){
				user1 = spieler;
						score1 ++;
						tabelle = 1;
			}
				}
					if(tabelle == 0){
			if(score2 == 0){
				user2 = spieler;
						score2 ++;
						tabelle = 1;
			}
					}
					if(tabelle == 0){
			if(score3 == 0){
				user3 = spieler;
						score3 ++;
						tabelle = 1;
			}
					}
					if(tabelle == 0){
			if(score4 == 0){
				user4 = spieler;
						score4 ++;
						tabelle = 1;
			}
					}
					if(tabelle == 0){
			if(score5 == 0){
				user5 = spieler;
						score5 ++;
						tabelle = 1;
			}
					}
					if(tabelle == 0){
			if(score6 == 0){
				user6 = spieler;
						score6 ++;
						tabelle = 1;
			}
					}
					if(tabelle == 0){
			if(score7 == 0){
				user7 = spieler;
						score7 ++;
						tabelle = 1;
			}
					}
					if(tabelle == 0){
			if(score8 == 0){
				user8 = spieler;
						score8 ++;
						tabelle = 1;
			}
					}
					if(tabelle == 0){
			if(score9 == 0){
				user9 = spieler;
						score9 ++;
						tabelle = 1;
			}
				}
				}
			}
				if(score2 > score1){
					zahl = score1;
					score1 = score2;
					score2 = zahl;
					speicher = user1;
					user1 = user2;
					user2 = speicher;
				}
					if(score3 > score2){
						zahl = score2;
						score2 = score3;
						score3 = zahl;
						speicher = user2;
						user2 = user3;
						user3 = speicher;
					}
					if(score4 > score3){
						zahl = score3;
						score3 = score4;
						score4 = zahl;
						speicher = user3;
						user3 = user4;
						user4 = speicher;
					}
					if(score5 > score4){
						zahl = score4;
						score4 = score5;
						score5 = zahl;
						speicher = user4;
						user4 = user5;
						user5 = speicher;
					}
					if(score6 > score5){
						zahl = score5;
						score5 = score6;
						score6 = zahl;
						speicher = user5;
						user5 = user6;
						user6 = speicher;
					}
					if(score7 > score6){
						zahl = score6;
						score6 = score7;
						score7 = zahl;
						speicher = user6;
						user6 = user7;
						user7 = speicher;
					}
					if(score8 > score7){
						zahl = score7;
						score7 = score8;
						score8 = zahl;
						speicher = user7;
						user7 = user8;
						user8 = speicher;
					}
					if(score9 > score8){
						zahl = score8;
						score8 = score9;
						score9 = zahl;
						speicher = user8;
						user8 = user9;
						user9 = speicher;
					}
			PlayerPrefs.SetInt("score1", score1);
			PlayerPrefs.SetInt("score2", score2);
			PlayerPrefs.SetInt("score3", score3);
			PlayerPrefs.SetInt("score4", score4);
			PlayerPrefs.SetInt("score5", score5);
			PlayerPrefs.SetInt("score6", score6);
			PlayerPrefs.SetInt("score7", score7);
			PlayerPrefs.SetInt("score8", score8);
			PlayerPrefs.SetInt("score9", score9);
			PlayerPrefs.SetString("user1", user1);
			PlayerPrefs.SetString("user2", user2);
			PlayerPrefs.SetString("user3", user3);
			PlayerPrefs.SetString("user4", user4);
			PlayerPrefs.SetString("user5", user5);
			PlayerPrefs.SetString("user6", user6);
			PlayerPrefs.SetString("user7", user7);
			PlayerPrefs.SetString("user8", user8);
			PlayerPrefs.SetString("user9", user9);

			spielvorbei1 = 1;
			//Time.timeScale = 0;
		}
	}
}
