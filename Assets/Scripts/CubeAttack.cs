using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAttack : CubeState
{
    public override void StateStart()
    {
        myCube.material.color = Color.red;
    }

    public override void StateUpdate()
    {
        if ((myCube.player.transform.position - transform.position).magnitude >= myCube.attackRange)
        {
            ChangeStateTo<CubeApproach>();
            return;
        }
    }

    public override void StateFixedUpdate()
    {

    }

    public override void StateExit()
    {

    }
}
