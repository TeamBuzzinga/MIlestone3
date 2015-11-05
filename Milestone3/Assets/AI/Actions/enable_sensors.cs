using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class enable_sensors : RAINAction
{
	public override void Start(RAIN.Core.AI ai)
	{
		base.Start(ai);
		ai.Senses.EnableSensor ("closeSensor");
		ai.Senses.EnableSensor ("nearbySensor");
	}
	
	public override ActionResult Execute(RAIN.Core.AI ai)
	{

		
		return ActionResult.SUCCESS;
	}
	
	public override void Stop(RAIN.Core.AI ai)
	{
		base.Stop(ai);
	}
}