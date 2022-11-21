using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodMoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(GetPosition(3,2,5));
    }

    Vector3 GetPosition(int x, int y, int z)
    {
        return new Vector3(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime);
    }
}
