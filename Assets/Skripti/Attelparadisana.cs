using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Attelparadisana : MonoBehaviour{
  public GameObject jurniekaKrekls;
  public GameObject baltsKrekls;
  public GameObject zilsKrekls;
  public GameObject zilsMetelis;
  public GameObject veste;
  public GameObject melnasBikses;
  public GameObject sarkanasBikses;
  public GameObject zilasBikses;
  public GameObject zabakiStripaini;
  public GameObject zabakiBruni;
  public GameObject jurniekaCepure;
  public GameObject piratuCepure;
  public GameObject lakats;
  public GameObject zobens;
  public GameObject josta;
  public GameObject parsejs;
  public GameObject mainigaisAttels;
  public GameObject slaideris1;
  public GameObject slaideris2;
  public Sprite[] atteluMasivs;
  
  



public void mainitIzmeru(){
    float pasreizejaVertiba = slaideris1.GetComponent<Slider>().value;
    float pasreizejaVertiba1 = slaideris2.GetComponent<Slider>().value;
    mainigaisAttels.transform.localScale = new Vector3(1F*pasreizejaVertiba1, 1F*pasreizejaVertiba, 1);
    mainigaisAttels.transform.localScale = new Vector3(1F*pasreizejaVertiba1, 1F*pasreizejaVertiba,1);
}


  public void krekluAttelosana(bool vertiba){
      jurniekaKrekls.SetActive(vertiba);
      baltsKrekls.SetActive(vertiba);
      zilsKrekls.SetActive(vertiba);
      zilsMetelis.SetActive(vertiba);
      veste.SetActive(vertiba);
  }
  public void biksesAttelosana(bool vertiba){
      melnasBikses.SetActive(vertiba);
      sarkanasBikses.SetActive(vertiba);
      zilasBikses.SetActive(vertiba);
  }
  public void apaviAttelosana(bool vertiba){
      zabakiStripaini.SetActive(vertiba);
      zabakiBruni.SetActive(vertiba);
  }
  public void cepuresAttelosana(bool vertiba){
      jurniekaCepure.SetActive(vertiba);
      lakats.SetActive(vertiba);
      piratuCepure.SetActive(vertiba);
  }
  public void aksesuariAttelosana(bool vertiba){
      zobens.SetActive(vertiba);
      josta.SetActive(vertiba);
      parsejs.SetActive(vertiba);
  }


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
