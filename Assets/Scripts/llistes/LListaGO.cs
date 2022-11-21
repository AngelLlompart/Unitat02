using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LListaGO : MonoBehaviour
{
    private GameObject[] _elements = new GameObject[3];

    private List<GameObject> _objectsCreated = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        _elements[0] = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        _elements[1] = GameObject.CreatePrimitive(PrimitiveType.Cube);
        _elements[2] = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        foreach (var element in _elements)
        {
           element.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            if(_objectsCreated.Count < 10){
                int x = Random.Range(-10, 11);
                int y = Random.Range(-10, 11);
                GameObject obj = Instantiate(_elements[Random.Range(0, _elements.Length)], new Vector3(x, y, 0), Quaternion.identity); 
                obj.SetActive(true);
                _objectsCreated.Add(obj);
            }
        }

        if (_objectsCreated.Count == 10)
        {
            foreach (var element in _objectsCreated)
            {
                element.GetComponent<MeshRenderer>().material.color = Color.green;
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (var element in _objectsCreated)
            {
                Destroy(element);
            }
           _objectsCreated.Clear();
        }
    }
}
