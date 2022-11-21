using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item3
{
    
    //array de fruita y atribut de coins??
    [SerializeField] private string name;
    [SerializeField] private int id;
    [SerializeField] private string description;
    public static int numItems;

    public Item3()
    {
        id = numItems;
        numItems++;
    }
    public Item3(string name, string description)
    {
        this.name = name;
        id = numItems;
        this.description = description;
        numItems++;
    }

    public virtual void MyTreat()
    {
        Debug.Log("Som un item general, no tenc característica especial");
    }

    public override string ToString()
    {
        if (String.IsNullOrEmpty(name))
        {
            return "Item #" + id;
        }
        return "Item #" + id + ": " + name + (!String.IsNullOrWhiteSpace(description) ? ", " + description : "");
    }
}