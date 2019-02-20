﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {


	[SerializeField] public Transform target;


	void Update()
	{

		InFront(); 
	}
	bool InFront()
	{
		Vector3 directionToTarget = transform.position - target.position;
		float angle = Vector3.Angle(transform.forward, directionToTarget);

		if (Mathf.Abs(angle) > 90 && Mathf.Abs(angle) < 270) 
		{
			Debug.DrawLine(transform.position, target.position, Color.green);
			return true; 
		}
		
		Debug.DrawLine(transform.position, target.position, Color.blue);
		return false; 
		
	} 
	
	
}
