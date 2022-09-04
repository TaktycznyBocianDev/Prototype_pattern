using UnityEngine;
using UnityEngine.UI;

public class WeaponShootingScript : MonoBehaviour
{

    [SerializeField]
    public WeaponsTemplate weaponData;

    [SerializeField]
    private Text victimText;
    [SerializeField]
    private Text victimSpecialDamageText;

    private void Start()
    {
        ChangeWeapon(weaponData);
    }

    public void Shoot()
    {
        victimText.text = "You have done " + weaponData.Damage + " to victim.";
        ClearSpecialTxt();

        if (weaponData.canDoFireDamage > 0)
        {
            victimSpecialDamageText.text = "You have done " + weaponData.canDoFireDamage + " fire damage";
        }
        if (weaponData.canDoWaterDamage > 0)
        {
            victimSpecialDamageText.text = "You have done " + weaponData.canDoWaterDamage + " water damage";
        }

        if (weaponData.canElectroDamage > 0)
        {
            victimSpecialDamageText.text = "You have done " + weaponData.canElectroDamage + " electro damage";
        }
    }

    private void ClearSpecialTxt()
    {
        victimSpecialDamageText.text = "";
    }

    public void ChangeWeapon(WeaponsTemplate weapons)
    {
        this.weaponData = weapons;
        GetComponent<SpriteRenderer>().sprite = weapons.weaponSprite;
    }

}
