using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithTrig : MonoBehaviour
{

	[Range(0, 2f * Mathf.PI)] public float theta;
	public float r = 5f; //units away from origin 
	public float speed = 15f;
	public float SinValue;
	public float angleInDegrees;
	private float abc;
	private TrailRenderer LR; 
		
	
	public Color c1 = Color.yellow;
	public Color c2 = Color.red;
	void Start ()
	{
	//origin 
		this.transform.position = Vector3.zero;
		LR = GetComponent<TrailRenderer>(); 
	}
	
	// Update is called once per frame

	
	void Update ()
	{		
		//each frame output of formula // create most basic version and exp with gvalues 
		//this.transform.position = PointOnCircle(theta, r); 
		//it will take 2 * PI seconds to rotate fully around! 

		//r -= 1; 	
		this.transform.position = PointOnCircle(Time.time * speed, r * Mathf.Sin(Time.time * SinValue));
		//makes chaotic lines: 
		//this.transform.position = PointOnCircle(Time.time * speed * Mathf.Cos(25 * Time.time), r * Mathf.Sin(Time.time * SinValue * Mathf.PI/2));

		
		Vector3 newPos = this.transform.position;
		newPos.z = Time.time;
		this.transform.position = newPos * Mathf.PI/2;
//		transform.Rotate(Vector3.right * Time.deltaTime * speed); 

	
	}
	
	//wtf you can have this as a function???!! 
	//procedural meshes, generate list of points / meshes 
	//HOMEWORK: Employ this function in some way 
	Vector3 PointOnCircle(float angle, float radius)
	{

		//x and y 
		//return new Vector3(radius * Mathf.Cos(angle), radius * Mathf.Tan(angle), 0); 
		
		//multiplying PI & dividing by 2 make a butterfly effect 
		//return new Vector3(radius * Mathf.Cos(angle / 2 * Mathf.PI/3), radius * Mathf.Sin(angle * Mathf.PI/3), Mathf.PI/2); 
		return new Vector3(radius * Mathf.Cos(angle), radius * Mathf.Sin(angle), Mathf.PI/2); 

	}
}
