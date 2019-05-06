﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionManager : MonoBehaviour {

	//This script ensures that collisions only happen once because we depend on the count to make changes to the scene.

	//I hope this will apply to all 2D collider-s so I don't have to specify 
	
	private Collider2D myCollider;
	private int CollisionCount; 
		
	void Start ()
	{
		myCollider = GetComponent<Collider2D>(); 
		//myCollider.enabled = true; 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.CompareTag("Ball"))
		{
			CollisionCount++; 
			//myCollider.enabled = false; 
			//Destroy(myCollider);
			Destroy(gameObject);
			Debug.Log(CollisionCount);
		}
		
	}
}
