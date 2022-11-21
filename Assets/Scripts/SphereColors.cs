using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColors : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var input = Input.inputString;
        switch (input)
        {
            case "1": this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case "2": this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case "3": this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case "4": this.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
        }
    }
}
