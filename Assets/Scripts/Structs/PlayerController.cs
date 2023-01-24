using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * _gameManager.Speed);

        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("Nom: " + _gameManager.Name + " speed: " + _gameManager.Speed);
        }
    }
}
