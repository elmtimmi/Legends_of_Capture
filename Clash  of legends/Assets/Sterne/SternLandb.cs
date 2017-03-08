using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SternLandb : MonoBehaviour {

    public GameObject RotDran;
    private Rotistdran a;


    void Start()
    {
        a = RotDran.GetComponent<Rotistdran>();
    }


    void Update()
    {
        if (a.map == 1)
        {
            //stern ist zu sehen auf c1, c5
            this.transform.position = new Vector3(231, 0, 80);

        }

        if (a.andermap == 1)
        {
            //Stern spawn weg und ist nicht mehr zu sehen
            this.transform.position = new Vector3(1000, 1000, 1000);
        }


        if (a.map == 2)

        {
            //Stern spawn weg und ist nicht mehr zu sehen
            this.transform.position = new Vector3(1000, 1000, 1000);
        }


        if (a.map == 3)

        {
            //Stern liegt bei Kordinaten 
            this.transform.position = new Vector3(526, 0, 150);


        }


        if (a.map == 4)

        {
            //1351 0 150 liegt die insel rechts mitte

            this.transform.position = new Vector3(1428, 0, 150);
        }
        /////////////////////////////////////////////////////////////////////////
        /// 
    }
}