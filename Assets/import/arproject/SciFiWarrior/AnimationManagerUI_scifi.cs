using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManagerUI_scifi : MonoBehaviour
{
	internal string _Animation = null;

	public void SetAnimation_Idle()
	{
		_Animation = "Idle_GunMiddle";
	}

	public void SetAnimation_RunGuard()
	{
		_Animation = "Run_Guard";
	}

	public void SetAnimation_ShootAuto()
	{
		_Animation = "Shoot_Auto";
	}

	public void SetAnimation_WalkForwardShoot()
	{
		_Animation = "WalkForward_Shoot";
	}


	
}
