using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeColorEvent.onPressKey += Position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Position()
    {
        transform.position = new Vector3(5, 2, 0);
        ChangeColorEvent.onPressKey -= Position;
    }
}
