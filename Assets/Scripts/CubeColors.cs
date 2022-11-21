using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColors : MonoBehaviour
{
    private int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            points += 5;
            Debug.Log(points);
        }

        if (points >= 50)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}
