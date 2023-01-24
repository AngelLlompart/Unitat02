using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item2
{
    
    //array de fruita y atribut de coins??
    [SerializeField] private string name;
    [SerializeField] private int id;
    [SerializeField] private string description;

    public Item2(string name, int id, string description)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }

    public string Name
    {
        get => name;
        set => name = value;
    }
    public virtual void MyTreat()
    {
        Debug.Log("Som un item general, no tenc característica especial");
    }

    public override string ToString()
    {
        return "Item #" + id + ": " + name + ", " + description;
    }
}