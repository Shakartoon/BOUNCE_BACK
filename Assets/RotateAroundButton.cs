using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundButton : MonoBehaviour
{

	public GameObject triangle;
	public bool topRightQuadrant = false; 
		
#pragma strict

	private float StartAngle = 0;

	void Start()
	{
		
	}

	private void OnMouseDown()
	{
		Debug.Log("YAS QUEEN");
		var ScreenPosition = Camera.main.WorldToScreenPoint(transform.position);
		var vector = Input.mousePosition - ScreenPosition;
		StartAngle = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
		StartAngle -= Mathf.Atan2(transform.right.y, transform.right.x) * Mathf.Rad2Deg;

	}

	void OnMouseDrag()
	{

		var ScreenPosition = Camera.main.WorldToScreenPoint(transform.position);
		var vector = Input.mousePosition - ScreenPosition;
		var angle = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle - StartAngle, Vector3.forward); 

	}

	void Update()
	{

		if (triangle.transform.position.y >= 0.31f)
		{
			topRightQuadrant = true; 

		}
	}

} 

	
/* 


	public float time;
	public float speed;
	public float width;
	public float height; 
	
	void Start()
	{
		speed = 2f;
		width = 2f;
		height = 2f; 

	}

	void Update()
	{

		time += Time.deltaTime * speed;

		float x = Mathf.Cos(time * width);
		float y = Mathf.Sin(time * height); 
		
		transform.position = new Vector2(x, y);

	}
} 

*/ 


/* 
public GameObject largeHalfCircle; 
private Vector2 direction;
private float distance;
private float check; 
 
 
 void Start () {
	
}

// Update is called once per frame
void Update () {

	if (isRotating)
	{
		direction = (Input.mousePosition - largeHalfCircle.transform.position);
		distance = Mathf.Sqrt(direction.x * direction.x + direction.y * direction.y);

		if (distance < 350 && distance > 150)
		{
			angle = Math 
			
		}

	}
	

	
}

} 

*/ 
