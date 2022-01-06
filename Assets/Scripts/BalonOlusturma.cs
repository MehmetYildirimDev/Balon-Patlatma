using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturma : MonoBehaviour
{
    public GameObject Balon;
    float BalonOlusturmaSuresi = 2f;
    float BalonZamanSayaci = 3f;

    OyunKontrol sureKontrol;//süreyi kontrol etmek için
    // Start is called before the first frame update
    void Start()
    {
        sureKontrol = this.gameObject.GetComponent<OyunKontrol>();
        //Burada neden find ile yapmadýk cunku BalonOlusturma scripti ile OyunKontrol scripti ayný gameobje Üzerinde 
    }

    
    // Update is called once per frame
    void Update()
    {
        int Hizkatsayi = (int)(sureKontrol.SureSayaci/10)-6;//süre azaldýkca hýzlanýcaklar
        Hizkatsayi *= -1;

        BalonZamanSayaci -= Time.deltaTime;//Saniyede bir deðer düþer
        if (BalonZamanSayaci < 0 && sureKontrol.SureSayaci>0)
        {
            //   Instantiate(Balon, new Vector3(Random.Range(-2.7f, 2.7f), -6f, 0), Quaternion.Euler(0, 0, 0))
            //burada kuvveti yeni olusturdu ve eulerli açýyý kullandý býr yere donmemesi icin

            GameObject gameObject = Instantiate(Balon, new Vector3(Random.Range(-2.7f, 2.7f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            //Bir Oyun objesi olarak bunu oluþtur ve  gameObject'e eþitle ///Bununla birlikte hem sahneye ekleyebiliyotuz hem kodlarda eriþebiliyoruz ////Sondaki as GameObjec unutma 

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f*Hizkatsayi,100f*Hizkatsayi), 0));//Kuvvet ekliyoruz

            BalonZamanSayaci = BalonOlusturmaSuresi;
        }
    }
}
