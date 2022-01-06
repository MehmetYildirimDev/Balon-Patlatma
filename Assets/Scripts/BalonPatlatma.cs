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
        //Scriptimizin baðlý oldugu bir oyun objesine eriþmek için buluyor -> Hangi oyun objesini bulacak ? "_Scripts" baðlý oldugu ->.GetComponent ile hangi script oldugunu seçiyoruz 
        ///Scripte böyle baðlanýyor
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject patlama;
  
    private void OnMouseDown()
    {
        GameObject patlamaAnimasyon = Instantiate(patlama, transform.position, transform.rotation) as GameObject;///obje ismini verdik , objenin konumunu verdik , döngüsel deðerleri verdik , oda bize oluþturucak
        Destroy(this.gameObject);//Bu oyun Objemizi yok et diyoruz /// týklanýldýgýnda
        Destroy(patlamaAnimasyon,0.167f);

        skorTakip.BalonEkle();
    }
}
