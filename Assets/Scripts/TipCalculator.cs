using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    [SerializeField]
    private float bill = 42.5f;

    [SerializeField] 
    private float tipAmount = 20.0f;

    private float totalAmount;
    // Start is called before the first frame update
    void Start()
    {
        float tip = bill * tipAmount / 100;
        totalAmount = bill + tip;
        Debug.Log("Bill :" + bill);
        Debug.Log("Tip :" + tip);
        Debug.Log("Total :" + totalAmount); 
       //Debug.Log(myTransform.position.y);
       Debug.Log(transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
