using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
     private static TextMeshProUGUI activeEnemiesText;
    // Start is called before the first frame update
    void Start()
    {
        activeEnemiesText = GameObject.Find("txtEnemies").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void UpdateEnemyCount(int enemies)
    {
        activeEnemiesText.text = "Enemies: " + enemies;
    }
}
