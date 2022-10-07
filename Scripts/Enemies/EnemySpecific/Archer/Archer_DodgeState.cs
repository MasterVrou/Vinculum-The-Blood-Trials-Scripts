using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer_DodgeState : DodgeState
{
    private Archer archer;
    public Archer_DodgeState(Entity entity, FiniteStateMachine stateMachine, string animBoolName, D_DodgeState stateData, Archer archer) : base(entity, stateMachine, animBoolName, stateData)
    {
        this.archer = archer;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (isDodgeOver)
        {
            if (!isPlayerInMaxAgroRange)
            {
                stateMachine.ChangeState(archer.lookForPlayerState);
            }
            else
            {
                stateMachine.ChangeState(archer.rangedAttackState);
            }
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
