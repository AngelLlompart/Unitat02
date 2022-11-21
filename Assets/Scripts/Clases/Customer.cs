using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer
{
    [SerializeField] private string firstName;
    [SerializeField] private string lastName;
    [SerializeField] private int age;
    [SerializeField] private Gender gender;
    [SerializeField] private string occupation;

    public Customer(string firstName, string lastName, int age, Gender gender, string occupation)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.occupation = occupation;
    }

    public override string ToString()
    {
        return "Name: " + firstName + " " + lastName + ". Age: " + age + ". Gener: " + gender + ". Occupation: " +
               occupation + ".";
    }

    public int Age
    {
        get => age;
        set => age = value;
    }
    public Gender CustomerGender
    {
        get => gender;
    }

    public string FirstName
    {
        get => firstName;
    }

    public string LastName
    {
        get => lastName;
    }
}
public enum Gender
{
    Male,
    Female
}
