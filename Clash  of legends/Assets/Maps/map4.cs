using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map4 : MonoBehaviour {
    public GameObject RotDran;
    private Rotistdran a;
    public int anderp;
    public int darfnoch;
    public int darfnoch1;

    // Use this for initialization
    void Start()
    {
        a = RotDran.GetComponent<Rotistdran>();
        anderp = 1;
    }

    // Update is called once per frame
    void Update()
    {

       if(a.map != 4)
        {
            if (darfnoch == 0)
            {
                var Richtung = new Vector3(0f, 0f, 10000f);
                this.transform.position += Richtung;
                darfnoch = 1;
                darfnoch1 = 0;
            }
        }else if(darfnoch1 == 0)
        {
            var Richtung = new Vector3(0f, 0f, 10000f);
            this.transform.position -= Richtung;
            darfnoch = 0;
            darfnoch1 = 1;
        }

    }
}
