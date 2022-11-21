using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    private int speed = 0;

    private int movespeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && speed > 0)
        {
            speed -= movespeed;
            Debug.Log(speed);
            if (speed == 0)
            {
                Debug.Log("SPEED UP");
            }
        }
        else if (Input.GetKeyDown(KeyCode.A) && speed < 20)
        {
            speed += movespeed;
            Debug.Log(speed);
            if (speed >= 20)
            {
                Debug.Log("SLOW DOWN");
            }
        }
    }
}
