using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeApproach : CubeState
{
    public override void StateStart()
    {
        myCube.material.color = Color.yellow;

        TipConsole.instance.Tip("Approach start");
    }

    public override void StateUpdate()
    {
        transform.Translate((myCube.player.transform.position - transform.position).normalized * 5 * Time.deltaTime);

        if((myCube.player.transform.position - transform.position).magnitude < myCube.attackRange)
        {
            ChangeStateTo<CubeAttack>();
            return;
        }

        if ((myCube.player.transform.position - transform.position).magnitude >= myCube.approachRange)
        {
            ChangeStateTo<CubeIdle>();
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
