using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class State : MonoBehaviour
{
    public string stateName;
    public Duck duck;

    public State(string name, Duck duck)
    {
        this.stateName = name;
        this.duck = duck;
    }

    public virtual void Enter() // runs once when you enter the state
    {

    }

    public virtual void Main() // runs every frame
    {

    }

    public virtual void Exit() // runs when its exiting (ex. transition into next state)
    {

    }
}