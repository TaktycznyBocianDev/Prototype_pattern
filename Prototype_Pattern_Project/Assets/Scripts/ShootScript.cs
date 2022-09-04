using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    private WeaponShootingScript weaponShooting;
    void Start()
    {
        weaponShooting = GetComponentInChildren<WeaponShootingScript>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            weaponShooting.Shoot();
        }
    }
}
