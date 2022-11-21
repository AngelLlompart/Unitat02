using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PowerUp();
        }

        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }
    }

    void Attack()
    {
        Debug.Log("ATTACK!");
    }

    void PowerUp()
    {
        Debug.Log("Power UP");
    }

    void Shoot()
    {
        Debug.Log("Shoot");
    }
}
