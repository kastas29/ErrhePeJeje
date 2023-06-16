using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Equip : Item
{
    public int level;
    public int Peso;
    public EquipmentType equipType;
    public float WeaponAttackCooldown;

    public int hp;
    public int stamina;
    public int mana;
    public int dmg;
    public int speed;
    public int criticalDmg;
    public int criticalPercent;
    public int criticalResistance;
    public int armor;
    public int shield;
    public int Mind;
    public int Dexterity;
    public enum EquipmentType
    {
        Helmet, Necklace, Chest, Ring, Pant, Shield, Boot, Weapon, Backpack
    }

    public override void Use()
    {
        Equipment.Instance.addEquip(this);
    }

    public override void Remove()
    {
        // Add to inventory
        // Remove from equipment
    }

}
