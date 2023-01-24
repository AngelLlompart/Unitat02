using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Speak();
       Eat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Speak()
    {
        Debug.Log("Speak!");
    }


    public void Eat()
    {
        Debug.Log("Nyam, nyam!");
    }
}
