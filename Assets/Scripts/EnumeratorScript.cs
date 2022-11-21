using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumeratorScript : MonoBehaviour
{
    private int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Countdown()
    {
        while (true)
        {
            Debug.Log(contador++);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
