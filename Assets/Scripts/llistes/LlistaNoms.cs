using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LlistaNoms : MonoBehaviour
{
    private List<String> _llistaNoms = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
       
        for (int i = 0; i < 5; i++)
        {
            int num1 = Random.Range(65, 91);
            int num2 = Random.Range(97, 123);
            int unicode = Random.Range(0, 2) == 0 ? num1 : num2;
            char character = (char) unicode;
            string text = character.ToString();
            _llistaNoms.Add(text);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var nom in _llistaNoms)
            {
                Debug.Log(nom);
            }

            if (_llistaNoms.Count == 0)
            {
                Debug.Log("No queden elements dins la llista");
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_llistaNoms.Count > 0)
            {
                int randomDelete = Random.Range(0, _llistaNoms.Count);
                Debug.Log("Deleting " + _llistaNoms[randomDelete]);
                _llistaNoms.RemoveAt(randomDelete);
            }
            else
            {
                Debug.Log("No queden elements dins la llista");
            }
            
        }
    }
}
