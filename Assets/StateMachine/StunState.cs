public class StunState : IState
{
    public void OnEnter(StateController controller)
    {
        throw new System.NotImplementedException();
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
