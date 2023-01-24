using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeColorEvent.onPressKey += TurnRed;  //important += si hi pot haver varis mètodes
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        ChangeColorEvent.onPressKey -= TurnRed;
    }

}
