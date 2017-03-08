using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angriffraduis : MonoBehaviour {
    public GameObject RotDran;
    private Rotistdran a;
    public GameObject AngriffVerschiebung;
    private AngriffS d;
    // Use this for initialization
    void Start () {
        a = RotDran.GetComponent<Rotistdran>();
        d = AngriffVerschiebung.GetComponent<AngriffS>();
    }
    void Update()
    {
        this.transform.position = a.pa - new Vector3(0, 0.0001f, 0);
        if(d.darfverschieben == 1)
        {
            d.darfverschieben = 2;
        }


    }
    void OnMouseDown()
    {
        d.darfverschieben = 1;
    }
        // Update is called once per frame
}
