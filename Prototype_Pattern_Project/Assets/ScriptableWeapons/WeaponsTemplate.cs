using UnityEngine;

[CreateAssetMenu(menuName = "Weapon Prototype")]
public class WeaponsTemplate : ScriptableObject
{
    [Header("Which button select this weapon?")]
    public KeyCode key;

    [Header("How much damage this weapon do?")]
    public int Damage;

    [Header("Weapon sprite")]
    public Sprite weaponSprite;

    [Header("How much can weapon do electro damage? \n0 - none")]
    public float canElectroDamage;
    [Header("How much can weapon do water damage? \n0 - none")]
    public float canDoWaterDamage;
    [Header("How much can weapon do fire damage? \n0 - none")]
    public float canDoFireDamage;


}
