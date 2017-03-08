using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public static float timer;
	public static bool timeStarted = false;
	public GameObject MainCamera;
	private pauseMenu a;
	public GameObject RotDran;
	private Rotistdran b;
	int einmal;
	
	
	// Use this for initialization
	void Start () {
		timeStarted = true;
		a = MainCamera.GetComponent<pauseMenu> ();
		b = RotDran.GetComponent<Rotistdran> ();
	}
	
	
	// Update is called once per frame
	void Update () {
		
		if (einmal == 1) {
			if (timeStarted == true) {
				timer += Time.deltaTime;
			}       
		
		}
	}
	
	
	void OnGUI() {
		if (b.anDerReihe == 2) {
			einmal = 1;
		}
		if(a.ispause == true){
		float minutes = Mathf.Floor(timer / 60);
		float seconds = timer%60;
		GUI.Label(new Rect(10,30,250,100),"Zeit: " + minutes + ":" + Mathf.RoundToInt(seconds));
	}
}
}
