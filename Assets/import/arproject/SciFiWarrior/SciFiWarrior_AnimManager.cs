using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SciFiWarrior_ : MonoBehaviour
{
	private Animator _SciFiWarriorAnimator;                //Character Animation
	internal string _SciFiWarriorAnimation = null;         //Character Animation Name
	private AnimationManagerUI _AnimationManagerUI;         //Character Animation UI Connection
	private string _SciFiWarriorLastAnimation = null;      //Character Last Animation

	// Start is called before the first frame update
	void Start()
    {
		_SciFiWarriorAnimator = this.gameObject.GetComponent<Animator>();
		_AnimationManagerUI = GameObject.Find("AnimationManagerUI_scifi").GetComponent<AnimationManagerUI>();

		Transform[] SciFiWarriorChildren = GetComponentsInChildren<Transform>();
	}

	// Update is called once per frame
	void Update()
	{
		//Get Animation from UI
		GetAnimation();

		//Set New Animation
		if (_SciFiWarriorLastAnimation != _SciFiWarriorAnimation)
			SetAnimation();
		else
		{
			ReturnToIdle();
		}

	}


	void GetAnimation()
	{
		//Record Last Animation
		_SciFiWarriorLastAnimation = _SciFiWarriorAnimation;


		if (_SciFiWarriorAnimation == null)
			_SciFiWarriorAnimation = "idle";

		else
		{
			//Set Animation Parameter
			_SciFiWarriorAnimation = _AnimationManagerUI._Animation;
			//_SapphiArtChanAnimation = "hit01";
		}
	}


	void SetAllAnimationFlagsToFalse()
	{
		_SciFiWarriorAnimator.SetBool("param_idletojump", false);
		_SciFiWarriorAnimator.SetBool("param_idletorunguard", false);
		_SciFiWarriorAnimator.SetBool("param_idletoshootsingle", false);
		_SciFiWarriorAnimator.SetBool("param_idletoshootauto", false);
		_SciFiWarriorAnimator.SetBool("param_idletodie", false);
		_SciFiWarriorAnimator.SetBool("param_idletowalkforwardshoot", false);
		
	}


	void SetAnimation()
	{
		SetAllAnimationFlagsToFalse();

		//IDLE
		if (_SciFiWarriorAnimation == "Idle_GunMiddle")
		{
			_SciFiWarriorAnimator.SetBool("param_toidle", true);
		}

		//WALK
		else if (_SciFiWarriorAnimation == "Shoot_Auto")
		{
			_SciFiWarriorAnimator.SetBool("param_idletoshootauto", true);
		}

		//RUN
		else if (_SciFiWarriorAnimation == "Run Guard")
		{
			_SciFiWarriorAnimator.SetBool("param_idletorunguard", true);
		}

		//JUMP
		else if (_SciFiWarriorAnimation == "WalkForward_Shoot")
		{
			_SciFiWarriorAnimator.SetBool("param_idletowalkforwardshoot", true);
		}

		
	}

	void ReturnToIdle()
	{
		/*if (_SciFiWarriorAnimator.GetCurrentAnimatorStateInfo(0).IsName(_SciFiWarriorAnimation))
		{
			if (
				_SciFiWarriorAnimation != "walk" &&
				_SciFiWarriorAnimation != "running" &&
				_SciFiWarriorAnimation != "ko_big" &&
				_SciFiWarriorAnimation != "winpose"
				)
			{
				SetAllAnimationFlagsToFalse();
				_SciFiWarriorAnimator.SetBool("param_toidle", true);
			}
		}*/
	}
}
