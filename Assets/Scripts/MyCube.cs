using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCube : MonoBehaviour
{
    public List<CubeState> cubeStates;

    public CubeState currentState;

    public GameObject player;

    public Material material;

    public float approachRange;
    public float attackRange;   
    private void Start()
    {
        material = GetComponent<MeshRenderer>().material;

        foreach(CubeState cubeState in cubeStates)
        {
            cubeState.myCube = this;
        }

        currentState.StateStart();
    }

    private void Update()
    {
        currentState.StateUpdate();
    }
}
