using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float speed;

    private string name;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        name = "Àngel";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Plus) || Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            speed++;
        }
        else if (Input.GetKeyDown(KeyCode.Minus)  || Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            speed--;
        }
    }

    public float Speed => speed;

    public string Name
    {
        get => name;
        set => name = value;
    }
}
