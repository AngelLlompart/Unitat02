using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculaMitjana : MonoBehaviour
{
    private int numNotes = 5;
    // Start is called before the first frame update
    void Start()
    {
        List<float> notes = new List<float>();
        for (int x = 0; x < numNotes; x++)
        {
            notes.Add(Random.Range(0f, 10.01f));
        }

        float total = 0;
        foreach (var nota in notes)
        {
            total += nota;
        }

        float average = total / notes.Count;
        Debug.Log("Mitjana :" + Mathf.Round(average * 100f)/100 + " " + MarkMessage(average));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string MarkMessage(float mark)
    {
        if (9 <= mark && mark <= 10)
        {
            return Qualifications.Excelent.ToString();
        }
        if (9 > mark && mark >= 7)
        {
            return Qualifications.Notable.ToString();
        }
        if (7 > mark && mark >= 6)
        {
            return Qualifications.Bé.ToString();
        }
        if (6 > mark && mark >= 5)
        {
            return Qualifications.Suficient.ToString();
        }

        return Qualifications.Insuficient.ToString();
    }

    enum Qualifications
    {
        Excelent,
        Notable,
        Bé,
        Suficient,
        Insuficient
    }
}
