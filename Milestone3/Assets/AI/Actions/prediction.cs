using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class prediction : RAINAction
{
	public GameObject player;
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
		player=GameObject.FindGameObjectWithTag("player");
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {


		location=ai.WorkingMemory.GetItem<Vector3>("location");

        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}