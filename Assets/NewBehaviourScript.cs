using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public string cod;
    public int gramos;

    // Start is called before the first frame update
    void Start()
    {
        float precio = 0.5f ;
        float desc;

        if(cod != "CHO" && cod != "FRU"&& cod != "DDL" && gramos < 250 && gramos > 3000)
        {
            Debug.Log("Error");
        }
        else if (cod == "CHO"|| cod == "DDL")
        {
            precio = precio * gramos;

            Debug.Log("El precio de su helado es de " + precio);
           
        }
        else if (cod == "FRU")
        {
            precio = precio * gramos;
            desc = precio * 10 / 100;
            precio = precio - desc;
            Debug.Log("El precio de su helado es de " + precio);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
