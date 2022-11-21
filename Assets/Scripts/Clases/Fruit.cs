using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Fruit : Item
{
    [SerializeField]
    private int health;
    public Fruit(string name, int id, string description, int hp, int health) : base(name, id, description, hp)
    {
        health = this.health;
    }

    public int Health
    {
        get => health;
        set => health = value;
    }
    
    public override void MyTreat()
    {
        Debug.Log("Som una fruita");
    }
}
