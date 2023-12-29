using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSM : MonoBehaviour
{
    public IdleState idle;
    public MatingState mate;
    public HungryState hungry;
    public ThirstyState thirsty;
    public Duck duck;

    public FSM(Duck duck)
    {
        this.duck = duck;
        idle = new IdleState("idle", duck);
        mate = new MatingState("mate", duck);
        hungry = new HungryState("hungry", duck);
        thirsty = new ThirstyState("thirsty", duck);
    }
}
