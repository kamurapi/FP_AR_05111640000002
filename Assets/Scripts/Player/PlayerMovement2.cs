using System.Collections;
using System.Collections.Generic;
using UnityEngine;



using UnityEngine.UI;

public class PlayerMovement2 : MonoBehaviour
{

	private Rigidbody rb;
	private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
		anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
		/*float x = CrossPlatformInputManager.GetAxis("Horizontal");
		float y = CrossPlatformInputManager.GetAxis("Vertical");

		Debug.Log(x+""+ y);
		transform.position += new Vector3(0, 0, y / 10);
		transform.position += new Vector3(x / 10, 0, 0);

		Vector3 movement = new Vector3(x, 0, y);

		rb.velocity = movement * 4f;

		if(x!=0 && y!=0)
		{
			transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
			anim.SetBool("IsRunning", true);
		}
		else
		{
			anim.SetBool("IsRunning", false);
		}*/
    }
}
