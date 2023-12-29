using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class IdleState : State
{
    public IdleState(string name, Duck duck) : base(name, duck)
    {

    }

    public override void Enter() //using the method from state class
    {
        
    }

    public override void Main() // runs every frame
    {

    }

    public override void Exit() // runs when its exiting (ex. transition into next state)
    {

    }
}
