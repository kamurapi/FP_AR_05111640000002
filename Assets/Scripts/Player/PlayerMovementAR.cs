using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAR : MonoBehaviour
{


	public float speed = 6f;
	public EasyJoystick moveJoy, rotateJoy;

	Vector3 movement;
	Animator anim;
	Rigidbody playerRigidbody;
	int floorMask;
	float camRayLength = 100f;
	private float h, v;


	void Awake()
	{
		floorMask = LayerMask.GetMask("Floor");
		anim = GetComponent<Animator>();
		playerRigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		//float h = Input.GetAxisRaw("Horizontal");
		//float v = Input.GetAxisRaw("Vertical");

		//moveJoy.Rotate(transform, 15.0F);                           //Rotate rigidbody;

		h = moveJoy.Coordinates.x;
		v = moveJoy.Coordinates.y;
		//Debug.Log(h + " " + v);
		moveJoy.Rotate(transform, 15.0F);
		
		if (moveJoy.IsPressed())
		{
			Move(h, v);
			//Shooting;


		}
		else
		{
			h = 0;
			v = 0;
		}
		//Debug.Log(h + " " + v);

		Turning();
		Animating(h, v);
	}

	// Start is called before the first frame update
	void Start()
	{
		movement.Set(0f, 0f, 0f);
		playerRigidbody.MovePosition(movement);
	}

	// Update is called once per frame
	void Update()
	{

	}

	// Plyaer Function -------------------------------------------------------------------
	void Move(float x, float y)
	{
		//movement.Set(x, 0f, y);
		Vector3 movement = new Vector3(x, 0, y);
		movement = movement.normalized * speed * Time.deltaTime;
		

		playerRigidbody.velocity = movement * 4f;
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
		//Debug.Log("eluer : " + transform.eulerAngles);
		playerRigidbody.MovePosition(transform.position + movement);
		//x = 0;
		//y = 0;
	}

	void Turning()
	{

		rotateJoy.Rotate(transform, 15.0F);
	}

	void Animating(float h, float v)
	{
		bool walking = h != 0f || v != 0f;
		anim.SetBool("IsRunning", walking);

	}

}
