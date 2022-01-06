using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text Zaman, Skor;
    public float SureSayaci = 5f;
    public GameObject patlamaAni;
    int skor = 0;
    // Start is called before the first frame update
    void Start()
    {
        Skor.text = "Skor: " + skor;

    }

    // Update is called once per frame
    void Update()
    {
        if (SureSayaci>0)
        {
            SureSayaci -= Time.deltaTime;
            Zaman.text = "Süre: " + SureSayaci.ToString("0.0");
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("Balon");//gameobjectlerden Tagi balon olanlarý bul ve diziye ekle diyoruz
            
            for (int i = 0; i < go.Length; i++)
            {
                Instantiate(patlamaAni, go[i].transform.position, go[i].transform.rotation); 
                
                Destroy(go[i]);
                
            }
            //en son patlama objesini de yok etmek istiyorum --> ve aþaðýda baþarýyorum 
            GameObject[] AnimasyonYokEt = GameObject.FindGameObjectsWithTag("Patlama");
            for (int i = 0; i < AnimasyonYokEt.Length; i++)
            {
                Destroy(AnimasyonYokEt[i], 0.167f);
            }
            
        }
        

    }
    public void BalonEkle()
    {
        skor += 1;
        Skor.text = "Skor: " + skor;
    }

}

