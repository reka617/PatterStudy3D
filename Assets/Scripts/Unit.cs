using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EUnitState
{
    none,
    Idle,
    Move,
    Attack,
    Die,
    Max
}

public class Unit : MonoBehaviour
{

    EUnitState _Estate = EUnitState.none;

    void Update()
    {
        StateCheck();  
    }

    void StateCheck()
    {
        if (_Estate == EUnitState.Idle) IdleState();
        if (_Estate == EUnitState.Move) MoveState();
        if (_Estate == EUnitState.Attack) AttackState();
        if (_Estate == EUnitState.Die) DieState();
    }

    void IdleState()
    {

    }

    void MoveState()
    {

    }

    void AttackState()
    {

    }

    void DieState() 
    {

    }
}


