using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubinSterna : MonoBehaviour {
    //Notizen
    // b4 300 0 300
    // -> a4 300 0 375
    // -> mitte oben 300 0 1220
    // f4 301 0 0
    //-> g4 301 0 -75
    // = mitte unten 301 0 -850


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
            this.transform.position = new Vector3(76, 0, 231);
        }

        if (a.andermap == 1)
        {
            //Stern spawn weg und ist nicht mehr zu sehen
            this.transform.position = new Vector3(1000, 500, 210);
        }


        if (a.map == 2)

        {
            //Stern spawn weg und ist nicht mehr zu sehen
            this.transform.position = new Vector3(1000, 500, 210);
        }


        if (a.map == 3)

        {
            // Stern ist zu sehen b4, f4
            this.transform.position = new Vector3(300, 0, 300);

        }


        if (a.map == 4)

        {
            //mitte oben und unten
            this.transform.position = new Vector3(300, 0, 1274);
        }
        /////////////////////////////////////////////////////////////////////////
        /// 
    }
}