using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWeapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int value = 0;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            value = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            value = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            value = 3;
        }
        
        switch (value)
        {
            case 1: Debug.Log("Gun");
                break;
            case 2: Debug.Log("Knife");;
                break;
            case 3: Debug.Log("Machine Gun");;
                break;
        }
    }
}
