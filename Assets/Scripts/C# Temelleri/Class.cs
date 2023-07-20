using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Araba araba1 = new Araba();

        araba1.marka = "BMW";
        araba1.model = "X5";
        araba1.fiyat = 500000;

        print(araba1.marka);
        print(araba1.model);
        print(araba1.fiyat);


        Araba araba2 = new Araba();

        araba2.marka = "Mercedes-Benz";
        araba2.model = "Cls";
        araba2.fiyat = 200000;

        print(araba2.marka);
        print(araba2.model);    
        print(araba2.fiyat); 

     
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



