using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashAbility : Ability
{
    string DashName;
    string DashDesc;

    private bool isDashing;
    private float dashCooldownTimer;

    public DashAbility()
    {
        this.DashName = "Dash";
        this.DashDesc = "Move forward quickly";
        this.isDashing = false;
        this.dashCooldownTimer = 0f;
    }

    public override void Activate()
    {
        if (dashCooldownTimer > 0f) // If dash is on cooldown
            return;

        if (!isDashing)
        {
            StartCoroutine(DashCoroutine());
        }
    }

    IEnumerator DashCoroutine()
    {
        isDashing = true;
        float dashTimer = PlayerManager.Instance.characterStats.dashDuration;
        float dashDistance = PlayerManager.Instance.characterStats.dashDistance * 2.5f;

        while (dashTimer > 0f)
        {
            print("dashTimer is greater than 0");
            //PlayerManager.Instance.rigidBody.MovePosition(PlayerManager.Instance.rigidBody.position + PlayerManager.Instance.movement * (dashDistance / PlayerManager.Instance.characterStats.dashDuration) * Time.deltaTime);
            dashTimer -= Time.deltaTime;
            yield return null;
        }

        StartCoroutine(CooldownDashCoroutine());
    }

    IEnumerator CooldownDashCoroutine()
    {
        dashCooldownTimer = PlayerManager.Instance.characterStats.dashCooldown;
        while (dashCooldownTimer > 0f)
        {
            dashCooldownTimer -= Time.deltaTime;
            yield return null;
        }

        isDashing = false;
    }
}
