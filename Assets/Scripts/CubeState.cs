using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeState : MonoBehaviour
{
    public MyCube myCube;
    public virtual void StateStart() { }

    public virtual void StateUpdate() { }

    public virtual void StateFixedUpdate() { }

    public virtual void StateExit() { }

    public void ChangeStateTo<T>()
    {
        foreach(CubeState cubeState in myCube.cubeStates)
        {
            if(cubeState is T)
            {
                myCube.currentState.StateExit();

                myCube.currentState = cubeState;
                myCube.currentState.StateStart();
            }
        }
    }

    public void ChangeStateTo<T>(System.Action onStateChange)
    {
        foreach (CubeState cubeState in myCube.cubeStates)
        {
            if (cubeState is T)
            {
                myCube.currentState.StateExit();
                onStateChange?.Invoke();
                myCube.currentState = cubeState;
                myCube.currentState.StateStart();
            }
        }
    }
}
