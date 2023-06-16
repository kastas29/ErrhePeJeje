using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public string abilityName;
    public string abilityDescription;
    public Sprite abilityIcon;
    public float abilityCooldown;
    public int abilityManaCost;

    public bool CanActivate(CharacterStats characterStats)
    {
        // Implement logic to check if the ability can be activated
        // For example, check if the cooldown is finished and the player has enough mana
        // Return true if the ability can be activated, otherwise false

        if (abilityCooldown > 0f)
        {
            return false; // Ability is still on cooldown
        }

        if (characterStats.current_mana < abilityManaCost)
        {
            return false; // Not enough mana to activate the ability
        }

        return true; // Ability can be activated
    }

    public abstract void Activate();

    protected void ApplyEffects()
    {
        // Implement logic to apply the effects of the ability
        // This could include damaging enemies, altering the environment, applying status effects, etc.
    }

}
