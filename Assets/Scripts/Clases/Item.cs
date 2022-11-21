using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    
    //array de fruita y atribut de coins??
    [SerializeField] private string name;
    [SerializeField] private int id;
    [SerializeField] private string description;
    [SerializeField] private int hp;
    [SerializeField] private GameObject _gameObject;

    public Item(string name, int id, string description, int hp)
    {
        this.name = name;
        this.id = id;
        this.description = description;
        this.hp = hp;
        this._gameObject = _gameObject;
    }

    public override string ToString()
    {
        return name + " HP: " + hp;
    }

    public int Hp
    {
        get => hp;
        set => hp = value;
    }

    public GameObject _GameObject
    {
        get => _gameObject;
        set => _gameObject = value;
    }
    
    public virtual void MyTreat()
    {
        Debug.Log("Som un item general, no tenc característica especial");
    }

}
