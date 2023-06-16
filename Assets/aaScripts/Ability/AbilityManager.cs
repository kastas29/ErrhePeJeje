using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbilityManager : MonoBehaviour
{
    public static AbilityManager Instance;
    private Dictionary<string, Ability> abilities = new Dictionary<string, Ability>();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddAbility(Ability ability)
    {
        abilities.Add(ability.name, ability);
    }

    public void RemoveAbility(string abilityName)
    {
        abilities.Remove(abilityName);
    }

    public bool CanActivateAbility(string abilityName, CharacterStats characterStats)
    {
        if (!abilities.ContainsKey(abilityName))
            return false; // Ability not found

        Ability ability = abilities[abilityName];

        if (!ability.CanActivate(characterStats))
            return false; // Ability cannot be activated

        return true; // Ability can be activated
    }

    public void ActivateAbility(string abilityName, CharacterStats characterStats)
    {
        if (!abilities.ContainsKey(abilityName))
            return; // Ability not found

        Ability ability = abilities[abilityName];

        if (!ability.CanActivate(characterStats))
            return; // Ability cannot be activated

        ability.Activate();
    }
}
