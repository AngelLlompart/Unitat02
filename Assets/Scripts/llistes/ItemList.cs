using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
    private List<Item2> _items = new List<Item2>();

    private Item2[] arrayIems = new Item2[5];
    // Start is called before the first frame update
    void Start()
    {
        arrayIems[0] = new Item2("Ball", 0, "sphere");
        arrayIems[1] = new Item2("Towel", 1, "b");
        arrayIems[2] = new Item2("Orange", 2, "fruit");
        arrayIems[3] = new Item2("Mouse", 3, "electronic");
        arrayIems[4] = new Item2("Laptop", 4, "n");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AddItem(arrayIems[Random.Range(0, 5)]);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_items.Count > 0)
            {
                RemoveItem(_items[Random.Range(0, _items.Count)]);
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
    }

    private void AddItem(Item2 item)
    {
        _items.Add(item);
    }

    private void RemoveItem(Item2 item)
    {
        _items.Remove(item);
    }
}
