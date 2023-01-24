using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pet
{
    public override void Speak()
    {
        Debug.Log("Woof! Woof!");
    }
}
