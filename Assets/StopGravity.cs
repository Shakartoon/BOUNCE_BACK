using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGravity : MonoBehaviour
{
	private Rigidbody2D myRB; 
	
	void Start ()
	{

		myRB = GetComponent<Rigidbody2D>();
		myRB.isKinematic = true; 
		//myRB.gravityScale = 0; 


	}
	
	void Update () {

		//myRB.gravityScale = 0; 
		
		/* 

		if (Input.GetMouseButtonDown(1))
		{
			
			myRB.gravityScale = 1; 

		}
		
		/* 
		if (Input.GetMouseButtonDown(1) == false)
		{

			myRB.gravityScale = 0; 

		}
		
		*/ 
		
	}
}
