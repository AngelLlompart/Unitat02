using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Coin : Item
{
    [SerializeField]
    private int points;
    public Coin(string name, int id, string description, int hp, int points) : base(name, id, description, hp)
    {
        points = this.points;
    }

    public int Points
    {
        get => points;
        set => points = value;
    }

    public override void MyTreat()
    {
        Debug.Log("Som una moneda");
    }
}
