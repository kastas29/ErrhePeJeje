public class StunState : IState
{
    public void OnEnter(StateController controller)
    {
        // The player is not able to move while this state is active
        // The player plays an animation of stunned
    }

    public void OnExit(StateController controller)
    {
        throw new System.NotImplementedException();
    }

    public void OnHurt(StateController controller)
    {
        controller.ChangeState(controller.hurtState);
    }

    public void UpdateState(StateController controller)
    {
        throw new System.NotImplementedException();
    }
}
