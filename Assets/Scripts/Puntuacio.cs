using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Puntuacio : MonoBehaviour
{
    private int _puntuacioInicial = 0;

    private bool hasSaidImage = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Puntuació intical: " + _puntuacioInicial);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _puntuacioInicial += 10;
            Debug.Log("Puntuació: " + _puntuacioInicial);
        }

        if (_puntuacioInicial >= 50 && hasSaidImage == false)
        {
            Debug.Log("Ets genial!");
            hasSaidImage = true;
        }

       
    }
}
