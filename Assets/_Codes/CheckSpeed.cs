using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSpeed : MonoBehaviour
{
	public float speed;
	public float adjustedSpeed; 
	private Rigidbody2D my_rb;
	private tempCollision tempCollision; 
	
	
	void Start ()
	{

		my_rb = GetComponent<Rigidbody2D>(); 

	}
	
	// Update is called once per frame
	void Update ()
	{

		//var vel = my_rb.velocity;
		//speed = vel.magnitude;
		//adjustedSpeed = speed / 10; 
		//var force = tempCollision.col.relativeVelocity.magnitude; 
		
		//Debug.Log(speed);


	}
}
