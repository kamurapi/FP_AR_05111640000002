using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimChan : MonoBehaviour
{
	private Animator anim;
	// Start is called before the first frame update
	void Start()
	{
		anim = GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update()
	{

	}

	public void animRunning()
	{
		anim.Play("running", -1, 0f);
	}

	public void animHit()
	{
		anim.Play("hit03", -1, 0f);
	}

	public void animWalkForwardShoot()
	{
		anim.Play("walk", -1, 0f);
	}
}
