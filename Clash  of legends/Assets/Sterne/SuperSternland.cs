using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSternland : MonoBehaviour {
 // map 1   228 0 223
 // map 2   1000 1000 1000
 //map 3   303 0 152
 //map 4   1000 1000 1000
 //andermap.a 234 0 380




 // Notizen für BauenS
 // Zeile du kopierst ab zeile 249 bis 284 #SpezialF.
 // zeilen angleichen
 //  Der Stamm muss gleich gleich 3 sein #Elf
 // spezialF. programmieren
 // neue variable 2x Bauen = 1;
 // 359 409 kopieren & angleichen
 // Zeile 385  angleichen
 // Gebäude ist die Variable welches gebäude ich bauen kann
 // 202 Enter if a.map > 3 {}
 //411 Enter



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
        this.transform.position = new Vector3(228, 0, 223);

    }

    if (a.andermap == 1)
    {
        //Stern spawn weg und ist nicht mehr zu sehen
        this.transform.position = new Vector3(234, 0, 380);
    }


    if (a.map == 2)

    {
        //Stern spawn weg und ist nicht mehr zu sehen
        this.transform.position = new Vector3(1000, 1000, 1000);
    }


    if (a.map == 3)

    {
        // Stern ist zu sehen b4, f4
        this.transform.position = new Vector3(303, 0, 152);


    }


    if (a.map == 4)

    {
        //Stern spawn weg und ist nicht mehr zu sehen
        this.transform.position = new Vector3(301, 0, 150);
    }
    /////////////////////////////////////////////////////////////////////////
    /// 
}
}