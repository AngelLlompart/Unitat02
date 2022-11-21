using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour2 : MonoBehaviour
{
    private UIManager2 _manager2;
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
        _manager2 = FindObjectOfType<UIManager2>();
        SpawnManager.numEnemies++;
        _manager2.UpdateText();
    }

    private void OnDisable()
    {
        _manager2 = FindObjectOfType<UIManager2>();
        SpawnManager.numEnemies--;
        _manager2.UpdateText();
    }
}
