using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ArrayNoms : MonoBehaviour
{
    public string[] noms;

    public int[] edats;

    public string[] cotxes;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log(noms[noms.Length-1] + " " + edats[edats.Length-1] + " " + cotxes[cotxes.Length-1]);

            int r = Random.Range(0, noms.Length);
           // Debug.Log(noms[r] + " " + edats[r] + " " + cotxes[r]);
           int i = 0;
            foreach (var nom in noms)
            {
                if (nom.Equals("Joan"))
                {
                    Debug.Log(nom + " " + edats[i] + " " + cotxes[i]);
                }
                i++;
            }
        }
    }
}
