using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayState : GameBaseState
{
    public override void EnterState(GameStateManager game)
    {
        Debug.Log("Play State Initialized!"); 
    }
    
    public override void UpdateState(GameStateManager game)
    {
        //
    }
    
    public override void ExitState(GameStateManager game)
    {
        Debug.Log("Play State Exited!"); 
    }
}
