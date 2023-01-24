using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList2 : MonoBehaviour
{
    private List<Item3> _items = new List<Item3>();

    // Start is called before the first frame update
    void Start()
    {
        _items.Add(new Item3("Orange", "fruit"));
        _items.Add(new Item3("Mouse", ""));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddItem();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_items.Count > 0)
            {
                RemoveItem();
            }
            else
            {
                Debug.Log("La llista ja esà buida");
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var item in _items)
            {
                Debug.Log(item.ToString());
            }
            Debug.Log("Hi ha " + _items.Count + " elements a la llista.");
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("S'han creat un total de " + Item3.NumItems + " items.");
        }
    }

    private void AddItem()
    {
        _items.Add(new Item3());
    }

    private void RemoveItem()
    {
        _items.Remove(_items[0]);   
    }
}