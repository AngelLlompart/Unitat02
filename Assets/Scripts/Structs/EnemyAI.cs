using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private EnemySate currentState;
    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemySate.Patroling;
        StartCoroutine(Chasing());
        StartCoroutine(Death());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentState);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = EnemySate.Attacking;
        }
    }

    enum EnemySate
    {
        Patroling,
        Attacking,
        Chasing,
        Death
    }

    IEnumerator Chasing()
    {
        yield return new WaitForSecondsRealtime(5);
        if (currentState == EnemySate.Patroling)
        {
            currentState = EnemySate.Chasing;
        }
    }
    
    IEnumerator Death()
    {
        yield return new WaitForSecondsRealtime(100);
        currentState = EnemySate.Death;
    }
}
