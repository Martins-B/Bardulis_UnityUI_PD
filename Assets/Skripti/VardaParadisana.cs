using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour{
    //Mainīgajā saglabās rekstu ko raksta teksta laukā
    public string teksts,vecums;
       //Lauks, kurā ieraksta tekstu
    public GameObject ievadesLauks, ievadesLauks2;
    //Kur attēlot tekstu
    public GameObject tekstaAttelosana;

    //Funkcija tiek izsaukta nospiežot pogu
    public void uzglabatTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        vecums = ievadesLauks2.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = teksts+" ir "+vecums+" gadus vecs!";
    }
}
