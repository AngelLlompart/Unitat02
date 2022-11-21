using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pares : MonoBehaviour
{
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        /*for (int i = 0; i <= 100; i++)
        {
            if (i%2 == 0)
            {
                Debug.Log(i);
            }

            if (i == 50)
            {
                Debug.Log("Ja ets a la meitat!");
            }
        }*/
        
       /* int i = 0;
        do
        {
            if (i%2 == 0)
            {
                Debug.Log(i);
            }

            if (i == 50)
            {
                Debug.Log("Ja ets a la meitat!");
            }

            i++;
        } while (i <= 100);*/

       int i = 0;
       while (i <= 100)  
       {
           if (i%2 == 0)
           {
               Debug.Log(i);
           }

           if (i == 50)
           {
               Debug.Log("Ja ets a la meitat!");
           }
           i++;
       }
    }

    // Update is called once per frame
    void Update()
    {
        if (i%2 == 0)
        {
            Debug.Log(i);
        }
            
        i++;
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            #if UNITY_EDITOR
            if(EditorApplication.isPlaying) 
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }
            #endif
        }
    }
}
