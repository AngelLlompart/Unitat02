using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        SpawnManager.numEnemies++;
        UIManager.UpdateEnemyCount(SpawnManager.numEnemies);
       // txtEnemies.text = "Enemies: " + SpawnManager.numEnemies;
    }

    private void OnDisable()
    {
        SpawnManager.numEnemies--;
        UIManager.UpdateEnemyCount(SpawnManager.numEnemies);
        //txtEnemies.text = "Enemies: " + SpawnManager.numEnemies;
    }
}
