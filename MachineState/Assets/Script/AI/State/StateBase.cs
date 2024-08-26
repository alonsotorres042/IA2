using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StateBase : MonoBehaviour
{
    protected MachineState _MachineState;
    public StateType stateType;
    public virtual void LoadComponent()
    {
        _MachineState = GetComponent<MachineState>();
    }
    public virtual void Enter()
    {

    }
    public virtual void Execute()
    {

    }
    public virtual void Exit()
    {

    }

}
