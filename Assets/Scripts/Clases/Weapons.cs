using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WeaponStats weaponStats = new WeaponStats("Blasters", 0.25f, 50);
        WeaponStats rockets = new WeaponStats("Rockets", 5f, 3);
        Debug.Log(weaponStats);
        Debug.Log(rockets);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class WeaponStats
{
    private string name;
    private float fireRate;
    private int ammo;

    public WeaponStats(string name, float fireRate, int ammo)
    {
        this.name = name;
        this.fireRate = fireRate;
        this.ammo = ammo;
    }

    public override string ToString()
    {
        return "Name: " + name + ". Fire rate: " + fireRate + ". Ammo: " + ammo;
    }
}
