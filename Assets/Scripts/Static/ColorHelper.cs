using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorHelper : MonoBehaviour
{
    public static Color defaultColor;
    static ColorHelper()
    {
        defaultColor = Color.blue;
    }

    public static void ChangeColor(GameObject go, Color color)
    {
        go.GetComponent<MeshRenderer>().material.color = color;
    }
    
    public static void ChangeColor(GameObject go)
    {
        Color random = new Color(Random.value, Random.value, Random.value);
        go.GetComponent<MeshRenderer>().material.color = random;
    }

    public static void SetDefaultColor(GameObject go)
    {
        go.GetComponent<MeshRenderer>().material.color = defaultColor;
    }
    
}
