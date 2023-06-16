using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTemplateManager : MonoBehaviour
{

    public Sprite[] skinList = new Sprite[4];

    [SerializeField] CharacterStats characterStats;
    [SerializeField] BaseStats baseStats;
    [SerializeField] InventoryContent inventory;
    [SerializeField] EquipmentContent equipment;



    public void ChangeSkin(string role)
    {
        switch (role)
        {
            case "Warrior":
                this.GetComponent<SpriteRenderer>().sprite = skinList[0];
                characterStats.sprite = this.GetComponent<SpriteRenderer>().sprite;
                break;
            case "Archer":
                this.GetComponent<SpriteRenderer>().sprite = skinList[1];
                characterStats.sprite = this.GetComponent<SpriteRenderer>().sprite;
                break;
            case "Wizard":
                this.GetComponent<SpriteRenderer>().sprite = skinList[2];
                characterStats.sprite = this.GetComponent<SpriteRenderer>().sprite;
                break;
            case "Assassin":
                this.GetComponent<SpriteRenderer>().sprite = skinList[3];
                characterStats.sprite = this.GetComponent<SpriteRenderer>().sprite;
                break;
        }
        startCharacterStats();
    }

    public void changeNameString(GameObject InputField)
    {
        characterStats.name = InputField.GetComponent<TextMeshProUGUI>().text.ToUpper();
    }

    public void startCharacterStats()
    {

        characterStats.hp_max = baseStats.Hp;
        characterStats.stamina_max = baseStats.Stamina;
        characterStats.stamina_regenVelocity = baseStats.Stamina_regenVelocity;
        characterStats.mana_max = baseStats.Mana;
        characterStats.mana_regenVelocity = baseStats.Mana_regenVelocity;
        characterStats.dmg = baseStats.Dmg;
        characterStats.speed = baseStats.Speed;
        characterStats.criticalDmg = baseStats.CriticalDmg;
        characterStats.criticalPercent = baseStats.CriticalPercent;
        characterStats.criticalResistance = baseStats.CriticalResistance;
        characterStats.armor = baseStats.Armor;
        characterStats.shield_max = baseStats.Shield;
        characterStats.damagePercent = baseStats.DamagePercent;
        characterStats.peso_max = baseStats.Peso;
        characterStats.xp = baseStats.Xp;
        characterStats.level = baseStats.Level;
        characterStats.xp_nextLevel = baseStats.Level;

        inventory.InventoryMaxCapacity = 105;
        inventory.Items.Clear();

        equipment.CharacterEquipment = new Equip[8];
        equipment.Backpacks = new Backpack[4];

    }

}
