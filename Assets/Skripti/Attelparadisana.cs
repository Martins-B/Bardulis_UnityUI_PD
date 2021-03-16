using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Attelparadisana : MonoBehaviour
{
    //Uzglabās mūsu bildes no ainas
  
  public GameObject mainigaisAttels;
  public Sprite[] atteluMasivs;

public void izkritosais(int skaitlis)
      {
          if(skaitlis == 0)
          {
              mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
          }else if (skaitlis == 1)
          {
              mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
          }
      }

      
}
