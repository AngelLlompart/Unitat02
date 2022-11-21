using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static int numEnemies;
    [SerializeField] 
    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject enemy = Instantiate(cube, new Vector3(Random.Range(-8, 8), Random.Range(-3,5), Random.Range(5, 20)), Quaternion.identity);
            StartCoroutine(DestroyThis(enemy));
        }
    }

    IEnumerator DestroyThis(GameObject go)
    {
        yield return new WaitForSeconds(10f);
        Destroy(go);
    }
}
