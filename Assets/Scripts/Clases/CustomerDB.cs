using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class CustomerDB : MonoBehaviour
{
    [SerializeField] 
    private Customer[] _customers = new Customer[4];
    
    // Start is called before the first frame update
    void Start()
    {
        _customers[0] = new Customer("Pepe", "Hernandez", 24, Gender.Male, "Software Developer");
        _customers[1] = new Customer("Neus", "Perez", 21, Gender.Female, "Arquitecta");
        _customers[2] = new Customer("Luis", "García", 35, Gender.Male, "Electricista");
        _customers[3] = new Customer("Sophie", "Lawrence", 28, Gender.Female, "Influencer");
    }

    // Update is called once per frame
    void Update()
    {
        string input = Input.inputString;
        int num;
        Int32.TryParse(input, out num);
        
        if (Input.GetKeyDown(KeyCode.T))
        { 
            ShowAll();
        }

        if ( num >= 1 && num < _customers.Length + 1)
        {
            ShowCustomerById(num - 1);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            ShowMales(Gender.Male);;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
           IncrementarEdat();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            ShowWithA();
        }
    }

    private void ShowAll()
    {
        foreach (var customer in _customers)
        {
            Debug.Log(customer);
        }
    }

    private void ShowMales(Gender gender)
    {
        foreach (var customer in _customers)
        {
            if (customer.CustomerGender == gender)
            {
                Debug.Log(customer);
            }
        }
    }

    private void ShowCustomerById(int num)
    {
        Debug.Log(_customers[num]);
    }

    private void IncrementarEdat()
    {
        foreach (var customer in _customers)
        {
            customer.Age += 3;
        }
        Debug.Log("Edat incrementada en 3");
    }

    private void ShowWithA()
    {
        foreach (var customer in _customers)
        {
            if (Regex.IsMatch(customer.FirstName, "[Aa]") || Regex.IsMatch(customer.LastName, "[Aa]"))
            {
                Debug.Log(customer);
            }
        }
    }   
}
