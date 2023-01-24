using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeColorEvent.onPressKey += Fall;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fall()
    {
        GetComponent<Rigidbody>().useGravity = true;
        ChangeColorEvent.onPressKey -= Fall;
    }
}
