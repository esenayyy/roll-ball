using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol1 : MonoBehaviour
{

    public int hiz;
    public Rigidbody fizik;
    public int puan;
    public int objeSayisi;

    public TMP_Text puanText;
    public TMP_Text oyunBittiText;


    // Start is called before the first frame update
    void Start()
    {

        fizik = GetComponent<Rigidbody>();
       // transform.Translate(0, 0, 5f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(0, 0, 0.01f);
        // transform.Rotate(0, 0, 0.1f);

        /* if (Input.GetKeyDown(KeyCode.Escape)) 
         {
             Debug.Log("ESC Tuþuna Basýldý!");
         }
         if (Input.GetKeyUp(KeyCode.E))
         {
             Debug.Log("E Tuþuna Basýldý!");
         }*/

       float yatay = Input.GetAxis("Horizontal");
       float dikey = Input.GetAxis("Vertical");

        //Debug.Log("yatay = " + yatay);
        //Debug.Log("dikey = " + dikey);

        Vector3 vektor = new Vector3(yatay, 0, dikey);

         fizik.AddForce(vektor*hiz);

    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        puan++;
        //puan += 1;
        // puan = puan+1;
        //Debug.Log("Puan = " + puan);
        puanText.text = "Puan:" + puan;

        if (puan == objeSayisi)
        {
           oyunBittiText.gameObject.SetActive(true);
        }
    }
}
