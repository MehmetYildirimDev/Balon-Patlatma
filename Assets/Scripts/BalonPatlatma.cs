using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonPatlatma : MonoBehaviour
{
    // Start is called before the first frame update


    OyunKontrol skorTakip;
    void Start()
    {
        skorTakip = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
        //Scriptimizin ba�l� oldugu bir oyun objesine eri�mek i�in buluyor -> Hangi oyun objesini bulacak ? "_Scripts" ba�l� oldugu ->.GetComponent ile hangi script oldugunu se�iyoruz 
        ///Scripte b�yle ba�lan�yor
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject patlama;
  
    private void OnMouseDown()
    {
        GameObject patlamaAnimasyon = Instantiate(patlama, transform.position, transform.rotation) as GameObject;///obje ismini verdik , objenin konumunu verdik , d�ng�sel de�erleri verdik , oda bize olu�turucak
        Destroy(this.gameObject);//Bu oyun Objemizi yok et diyoruz /// t�klan�ld�g�nda
        Destroy(patlamaAnimasyon,0.167f);

        skorTakip.BalonEkle();
    }
}
