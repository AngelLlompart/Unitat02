using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStructs : MonoBehaviour
{
    
    
    private struct ItemS
    {
        public string itemName;
        public int itemId;
    }

    private int x;
    // Start is called before the first frame update
    void Start()
    {
        Item2 itemC = new Item2("aa", 3, "a");
        ItemS itemS = new ItemS();
        itemS.itemName = "A";
        itemS.itemId = 1;
        x = 5;
        ChangeNameItem("Pau", itemC);
        ChangeNameItem("Pedro", itemS);
        ChangeNum(x);
        Debug.Log(x);
        Debug.Log(itemC.Name);
        Debug.Log(itemS.itemName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeNum(int a)
    {
        a = 10;
    }
    private void ChangeNameItem(string nom, ItemS itemS)
    {
        itemS.itemName = nom;
    }

    private void ChangeNameItem(string nom, Item2 item2)
    {
        item2.Name = nom;
    }
}
