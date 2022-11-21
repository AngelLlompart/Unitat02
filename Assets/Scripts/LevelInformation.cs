using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInformation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(0, 3);
        Difficulty(x);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            Difficulty(Random.Range(0, 3));
        }
    }

    void Difficulty(int x)
    {
        switch (x)
        {
           case (int) Difficulties.Easy: Debug.Log(Difficulties.Easy); 
               break;
           case (int) Difficulties.Medium: Debug.Log(Difficulties.Medium);
               break;
           case (int) Difficulties.Hard: Debug.Log(Difficulties.Hard);
               break;
           default: Debug.Log("Error");
               break;;
        }
    }

    enum Difficulties
    {
        Easy,
        Medium,
        Hard
    }
}
