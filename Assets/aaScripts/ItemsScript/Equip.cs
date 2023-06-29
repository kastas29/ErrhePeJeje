using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Equip : Item
{
    public EquipmentType equipType;
    public float WeaponAttackCooldown;
    public int Dmg;
    public int Stamina;
    public int Mana;
    public int HP;
    public int Armor;

    public enum EquipmentType
    {
        Helmet, Necklace, Chest, Ring, Pant, Shield, Boot, Weapon, Backpack
    }

    public override void Use()
    {
        Equipment.Instance.AddEquip(this);
    }

    public override void Remove()
    {
        // Remove from equipment
        Equipment.Instance.Unequip(this);
    }

}
