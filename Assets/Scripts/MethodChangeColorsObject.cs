using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodChangeColorsObject : MonoBehaviour
{
    [SerializeField]
    private GameObject objec;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(objec, Color.black);
        }
    }

    void ChangeColor(GameObject go, Color color)
    {
        go.GetComponent<MeshRenderer>().material.color = color;
    }
}
