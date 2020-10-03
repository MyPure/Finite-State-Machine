using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeIdle : CubeState
{
    public override void StateStart()
    {
        myCube.material.color = Color.white;
        TipConsole.instance.Tip("Idle start");
        Debug.Log("Start");
    }

    public override void StateUpdate()
    {
        if((myCube.player.transform.position - transform.position).magnitude < myCube.approachRange)
        {
            ChangeStateTo<CubeApproach>(() => {
                TipConsole.instance.Tip("Idle -> Approach translate");
            });
            return;
        }
    }

    public override void StateFixedUpdate()
    {
       
    }

    public override void StateExit()
    {
        TipConsole.instance.Tip("Idle exit");
    }
}
