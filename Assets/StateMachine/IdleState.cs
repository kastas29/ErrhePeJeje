using UnityEngine;

public class IdleState : IState
{
    Vector2 playerMovement;

    public void OnEnter(StateController controller)
    {
        Debug.Log("OnEnter Idle");
        controller.PlayerPrefab.GetComponent<Animator>().Play("IdleAnimation");
    }

    public void OnExit(StateController controller)
    {
        Debug.Log("OnExit Idle");
    }

    public void OnHurt(StateController controller)
    {
        controller.ChangeState(controller.hurtState);
    }

    public void UpdateState(StateController controller)
    {
        Debug.Log("Update Idle");
        playerMovement = PlayerManager.Instance.PlayerMovement;
        if (playerMovement != Vector2.zero) controller.ChangeState(controller.walkState);
    }
}
