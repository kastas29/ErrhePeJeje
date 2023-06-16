using UnityEngine;

public class WalkState : IState
{
    Vector2 playerMovement;
    Transform PlayerTransform;
    Rigidbody2D PlayerRigidBody;

    public void OnEnter(StateController controller)
    {
        Debug.Log("OnEnter Walk");
        PlayerTransform = controller.PlayerPrefab.GetComponent<Transform>();
        PlayerRigidBody = controller.PlayerPrefab.GetComponent<Rigidbody2D>();
        controller.PlayerPrefab.GetComponent<Animator>().Play("WalkAnimation");
    }

    public void OnExit(StateController controller)
    {
        Debug.Log("OnExit Walk");
    }

    public void OnHurt(StateController controller)
    {
        controller.ChangeState(controller.hurtState);
    }

    public void UpdateState(StateController controller)
    {
        Debug.Log("Update Walk");
        if (PlayerManager.Instance.PlayerCanMove)
        {
            playerMovement = PlayerManager.Instance.PlayerMovement;
            if (PlayerManager.Instance.PlayerMovement != Vector2.zero)
            {
                // Player walk
                PlayerRigidBody.velocity = playerMovement * PlayerManager.Instance.characterStats.speed;


                if (playerMovement.x > 0)
                {
                    PlayerTransform.localRotation = Quaternion.Euler(0, 0, 0);
                }
                else if (playerMovement.x < 0)
                {
                    PlayerTransform.localRotation = Quaternion.Euler(0, 180, 0);
                }
            }
            else
            {
                PlayerRigidBody.velocity = Vector2.zero;
                controller.ChangeState(controller.idleState);
            }
        } else
        {
            Debug.Log("I cant move lmao");
        }
    }
}
