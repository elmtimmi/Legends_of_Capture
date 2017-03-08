using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SternLanda : MonoBehaviour {
    //d1 76 0 150  - 825
    // -751

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
            this.transform.position = new Vector3(231, 0, 381);

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
            // Stern ist zu sehen d1
            this.transform.position = new Vector3(76, 0, 150);


        }


        if (a.map == 4)

        {
            //mitte links Stern
            this.transform.position = new Vector3(-824, 0, 150);
        }
        /////////////////////////////////////////////////////////////////////////
        /// 
    }
}
