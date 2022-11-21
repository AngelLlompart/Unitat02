using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edat : MonoBehaviour
{
    [SerializeField] private int age = 11;
    // Start is called before the first frame update
    void Start()
    {
        if (age < 18)
        {
            Debug.Log("No pot conduir");
        }
        else
        {
            Debug.Log("Pot conduir");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
