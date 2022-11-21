using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 10; i >= 0; i--)
        {
            Debug.Log(i);
            if (i == 0)
            {
                Debug.Log("Run!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
