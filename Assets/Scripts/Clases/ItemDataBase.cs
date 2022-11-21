using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    [SerializeField]
    private Item[] items;

    [SerializeField]
    private Fruit _fruit;

    [SerializeField]
    private Coin _coin;
    
    private int value;
    // Start is called before the first frame update
    void Start()
    {
        //Item item2 = new Item("Player", 1, "Player of the game", 10);
        Debug.Log(items[0]);
        items[1] = new Fruit("Platano", 99, "", 0, 100);
        items[2] = new Fruit("Cereza", 101, "", 0, 100);
        items[3] = new Coin("Coin2", 122, "", 0, 0);
        // _fruit = new Fruit("Manzana", 99, "", 100);
        // _coin = new Coin("Coin", 100, "", 1, 0);
        //Debug.Log(item2);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1) ||  Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            foreach (var item in items)
            {
                item._GameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            }
            value = Int32.Parse(Input.inputString) - 1;
            items[value]._GameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            Debug.Log("You have selected " + items[value]);
       
            Debug.Log("Type A to increase HP or D to decrease");
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            items[value].Hp++;
            Debug.Log(items[value]);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            items[value].Hp--;
            Debug.Log(items[value]);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            _coin.Points++;
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            _fruit.Health--;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            foreach (var item in items)
            {
                item.MyTreat();
            }
            Debug.Log("Points: " + _coin.Points + " Health: " + _fruit.Health);
        }
    }
}