using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dormir : StateMove
{
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
        Debug.Log("Dormir Enter ");
    }
    public override void Execute()
    {
        // Calcula la fuerza de direcci�n
        Vector3 steeringForce = _SteeringBehavior.Arrive(place);

        // Aplica la fuerza a la velocidad
        _SteeringBehavior.ClampMagnitude(steeringForce);

        // Actualiza la posici�n del objeto
        _SteeringBehavior.UpdatePosition();
        Debug.Log("Jugar Execute ");
    }
    public override void Exit()
    {
        Debug.Log("Dormir Exit ");
    }
    // Update is called once per frame
    
}
