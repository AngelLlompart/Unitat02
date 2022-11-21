using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionArray : MonoBehaviour
{

    [SerializeField]
    private Vector3[] position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = RandomPosition();
        }
    }

    int RandomIndex()
    {
        return Random.Range(0, position.Length);
    }

    Vector3 RandomPosition()
    {
       return position[RandomIndex()];
    }
}
