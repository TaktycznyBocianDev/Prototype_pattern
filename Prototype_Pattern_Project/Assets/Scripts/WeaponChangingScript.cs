using UnityEngine;

public class WeaponChangingScript : MonoBehaviour
{
    [SerializeField]
    private WeaponsTemplate[] weapons;

    private WeaponShootingScript weaponShooting;

    void Start()
    {
        weaponShooting = GetComponentInChildren<WeaponShootingScript>();
    }


    void Update()
    {
        if (Input.anyKeyDown)
        {
            foreach (WeaponsTemplate weapon in weapons)
            {
                if (Input.GetKeyDown(weapon.key))
                {
                    weaponShooting.ChangeWeapon(weapon);
                }
            }
        }
    }
}
