using UnityEngine;

public class MouseAttackState : IState
{
    float WeaponAttackCooldown;

    public void OnEnter(StateController controller)
    {
        Debug.Log("OnEnter MouseAttack");
        PlayerManager.Instance.PlayerCanMove = false;
        // Check whether or not the player has a weapon
        if (PlayerManager.Instance.equipmentContent.CharacterEquipment[7] != null) // Means that the player has a weapon equiped
        {
            Equip equippedWeapon = PlayerManager.Instance.equipmentContent.CharacterEquipment[7];
            WeaponAttackCooldown = equippedWeapon.WeaponAttackCooldown * PlayerManager.Instance.characterStats.AttackCooldownMultiplier;
            PlayerManager.Instance.GetComponent<Animator>().Play("WeaponAttack");
        }
        else
        {
            WeaponAttackCooldown = 1f * PlayerManager.Instance.characterStats.AttackCooldownMultiplier;
            PlayerManager.Instance.GetComponent<Animator>().Play("NoWeaponAttack");
        }
    }

    public void OnExit(StateController controller)
    {
        Debug.Log("OnExit MouseAttack");
        PlayerManager.Instance.PlayerMovement = Vector2.zero;
        PlayerManager.Instance.PlayerCanMove = true;
    }

    public void OnHurt(StateController controller)
    {
        controller.ChangeState(controller.hurtState);
    }

    public void UpdateState(StateController controller)
    {
        Debug.Log("Update MouseAttack");

        while (WeaponAttackCooldown > 0f)
        {
            Debug.Log("CD Remaining: " + WeaponAttackCooldown);
            WeaponAttackCooldown -= Time.deltaTime;
        }

        // Play some audio to notify that cd has finished

        if (WeaponAttackCooldown <= 0)
        {
            Debug.Log("CD should be 0 or less");
            controller.ChangeState(controller.idleState);
        }
    }
}
