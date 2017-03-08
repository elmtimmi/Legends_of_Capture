using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {
	Rect butRect;
	float ctrlWidh = 160;
	float ctrlHight = 30;
	// Use this for initialization
	void OnGUI(){
		butRect = new Rect ((Screen.width - ctrlWidh) / 2, 300, ctrlWidh, ctrlHight);
		if (GUI.Button (butRect, "Start")) {
			Application.LoadLevel (1);
			Vector3 temp = new Vector3(1000000f, 15f,1000000f);
			this.transform.position = temp;
		}
	}
}
