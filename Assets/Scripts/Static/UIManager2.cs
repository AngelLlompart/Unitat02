using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager2 : MonoBehaviour
{
    private TextMeshProUGUI txtEnemies;
    // Start is called before the first frame update
    void Start()
    {
        txtEnemies = GameObject.Find("txtEnemies").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateText()
    {
        txtEnemies.text = "Enemies: " + SpawnManager.numEnemies;
    }
}
