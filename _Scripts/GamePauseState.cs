using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauseState : GameBaseState
{
    public override void EnterState(GameStateManager game)
    {
        Debug.Log("Pause State Initialized!"); 
    }
    
    public override void UpdateState(GameStateManager game)
    {
        //
    }
    
    public override void ExitState(GameStateManager game)
    {
        Debug.Log("Pause State Exited!"); 
    }
}
