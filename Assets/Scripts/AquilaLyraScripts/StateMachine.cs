using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState{
    void Enter();
    void Execute();
    void Exit();
}
public class StateMachine : MonoBehaviour
{
    IState curState;

    void ChangeState(IState next) {
        if (curState != null) {
            curState.Exit();
        }
        curState = next;
        curState.Enter():
    }    
    
    void Update() {
        if (curState != null) {
            curState.Execute();
        }
    }

    IState currentState() {
        return curState;
    }
}