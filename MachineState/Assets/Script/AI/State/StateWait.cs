using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateWait : StateBase
{

    protected Coroutine coroutine;
    protected bool WaitTime = false;
    public float TimeWait;
    // Start is called before the first frame update
    void Start()
    {
        this.LoadComponent();
    }
    public override void LoadComponent()
    {

        base.LoadComponent();

    }
    public override void Enter()
    {
        coroutine = StartCoroutine(RunWait());
        base.Enter();
    }
    IEnumerator RunWait()
    {
        WaitTime = true;
        yield return new WaitForSeconds(TimeWait);
        WaitTime = false;
        StopCoroutine(coroutine);
    }
    public override void Execute()
    {

        base.Execute();
    }
    public override void Exit()
    {
        
        base.Exit();
    }
}
