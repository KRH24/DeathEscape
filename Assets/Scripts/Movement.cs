using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public Transform player;
	public float vert;
	public Rigidbody rb;
	private bool wantJump; 
	private bool isGrounded;
	[Header("Movement Settings")]
	public float speed = 5f;

	[Header("Key Bindings")]
	public KeyCode moveUpKey = KeyCode.W;
	public KeyCode moveDownKey = KeyCode.S;
	public KeyCode moveLeftKey = KeyCode.A;
	public KeyCode moveRightKey = KeyCode.D;

	private Vector3 movement;

	public Camera playerCamera;
    
	//public Transform axeTransform; 

	void Start()
	{
		playerCamera = Camera.main;  
		vert = 20f;
		rb = player.GetComponent<Rigidbody>();
	}

	void Update()
	{
		movement = Vector3.zero;


		Vector3 forward = playerCamera.transform.forward;
		Vector3 right = playerCamera.transform.right;


		forward.y = 0f;
		right.y = 0f;
		forward.Normalize();
		right.Normalize();


		if (Input.GetKey(moveUpKey))
		{
			movement += forward; 
		}
		if (Input.GetKey(moveDownKey))
		{
			movement -= forward;  
		}
		if (Input.GetKey(moveLeftKey))
		{
			movement -= right; 
		}
		if (Input.GetKey(moveRightKey))
		{
			movement += right; 
		}
		if(Input.GetKeyDown(KeyCode.Space))
			{
			
			wantJump = true;
			
			}


		if (movement.magnitude > 1)
		{
			movement.Normalize();
		}


		//transform.position += movement * speed * Time.deltaTime;
	    
		if (movement.sqrMagnitude > 0.01f) // Only rotate if moving
		{
			Quaternion targetRotation = Quaternion.LookRotation(movement, Vector3.up);
			transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);

			// If the axe is a separate object, rotate it to match player rotation
			//if (axeTransform != null)
			//{
			//	axeTransform.rotation = //Quaternion.Slerp(axeTransform.rotation, targetRotation, Time.deltaTime * 10f);
			//}
	    

		}
		
		
	}
		
		
		
	void FixedUpdate(){
			
			
		Vector3 move = movement * speed * Time.fixedDeltaTime;
		rb.MovePosition(rb.position + move);
		isGrounded = Physics.Raycast(player.position, Vector3.down, 1.1f);

		if (wantJump && isGrounded)
		{
			rb.AddForce(Vector3.up * vert, ForceMode.Impulse);
			wantJump = false;
		}
		else
		{
			wantJump = false; // prevent stuck jump input
		}	
			
			
			
	}

}
