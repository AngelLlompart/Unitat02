using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorEvent : MonoBehaviour
{
    public delegate void ActionKey();
    public static event ActionKey onPressKey;
  
    public void Update ()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (onPressKey != null)
            {
                onPressKey();
            }

        }
    }

}
