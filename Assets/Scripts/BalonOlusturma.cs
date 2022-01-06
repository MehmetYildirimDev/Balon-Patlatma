using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturma : MonoBehaviour
{
    public GameObject Balon;
    float BalonOlusturmaSuresi = 2f;
    float BalonZamanSayaci = 3f;

    OyunKontrol sureKontrol;//s�reyi kontrol etmek i�in
    // Start is called before the first frame update
    void Start()
    {
        sureKontrol = this.gameObject.GetComponent<OyunKontrol>();
        //Burada neden find ile yapmad�k cunku BalonOlusturma scripti ile OyunKontrol scripti ayn� gameobje �zerinde 
    }

    
    // Update is called once per frame
    void Update()
    {
        int Hizkatsayi = (int)(sureKontrol.SureSayaci/10)-6;//s�re azald�kca h�zlan�caklar
        Hizkatsayi *= -1;

        BalonZamanSayaci -= Time.deltaTime;//Saniyede bir de�er d��er
        if (BalonZamanSayaci < 0 && sureKontrol.SureSayaci>0)
        {
            //   Instantiate(Balon, new Vector3(Random.Range(-2.7f, 2.7f), -6f, 0), Quaternion.Euler(0, 0, 0))
            //burada kuvveti yeni olusturdu ve eulerli a��y� kulland� b�r yere donmemesi icin

            GameObject gameObject = Instantiate(Balon, new Vector3(Random.Range(-2.7f, 2.7f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            //Bir Oyun objesi olarak bunu olu�tur ve  gameObject'e e�itle ///Bununla birlikte hem sahneye ekleyebiliyotuz hem kodlarda eri�ebiliyoruz ////Sondaki as GameObjec unutma 

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f*Hizkatsayi,100f*Hizkatsayi), 0));//Kuvvet ekliyoruz

            BalonZamanSayaci = BalonOlusturmaSuresi;
        }
    }
}
