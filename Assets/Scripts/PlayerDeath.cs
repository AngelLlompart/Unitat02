using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    private int hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hp > 0)
        {
            int dmg = Random.Range(1, 100);
            Damage(dmg);
        }
    }

    void Damage(int dmg)
    {
        hp -= dmg;
        
        Debug.Log("T'han fet "+ dmg + " mal"); 
        if (!IsDead())
        {
            Debug.Log("Et queda " + hp + " de vida"); 
        }
    }

    bool IsDead()
    {
        if (hp > 0)
        {
            return false;
        }
        Debug.Log("Has mort");
        return true;
    }
    
}
