using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    public IState currentState;

    // States List
    public IdleState idleState = new IdleState();
    public WalkState walkState = new WalkState();
    public StunState stunState = new StunState();
    public MouseAttackState mouseAttackState = new MouseAttackState();
    public HurtState hurtState = new HurtState();

    public GameObject PlayerPrefab;

    public static StateController Instance;
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

    private void Start()
    {
        // At the start of the game, set the player state to IDLE
        ChangeState(idleState);
    }

    void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateState(this);
        }
    }
    public void ChangeState(IState newState)
    {
        Debug.Log("I want to change to " + newState + " State");
        if (currentState != null)
        {
            currentState.OnExit(this);
        }
        currentState = newState;
        currentState.OnEnter(this);
    }
}

public interface IState
{
    public void OnEnter(StateController controller);
    public void UpdateState(StateController controller);
    public void OnHurt(StateController controller);
    public void OnExit(StateController controller);
}
