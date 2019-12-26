using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimSciFi : MonoBehaviour
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
		anim.Play("Run_Guard", -1, 0f);
	}

	public void animShootAuto()
	{
		anim.Play("Shoot_Auto", -1, 0f);
	}

	
}
