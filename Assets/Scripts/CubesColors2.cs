using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesColors2 : MonoBehaviour
{

    
    private GameObject c1; 
    private GameObject c2; 
    private GameObject c3;

    private GameObject[] c;
    // Start is called before the first frame update
    void Start()
    {
        c1 = GameObject.Find("c1");
        c2 = GameObject.Find("c2");
        c3 = GameObject.Find("c3");
        c =  new GameObject[] { c1, c2, c3 };


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            foreach (var cube in c)
            {
                cube.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i].GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }
    }
}
