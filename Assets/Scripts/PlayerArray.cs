using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetAllPlayers();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    GameObject[] GetAllPlayers()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        foreach (var player in players)
        {
            player.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        return players;
    }
}
