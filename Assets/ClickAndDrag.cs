﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(CircleCollider2D))]

public class ClickAndDrag : MonoBehaviour
{

	private Vector3 offset;
	private Vector3 mousePosition; 
	public float moveSpeed = 0.5f;

	void Start()
	{
		//halo = (Behaviour)GetComponent("Halo");
	}
	void OnMouseDown()
	{
		//halo.enabled = true; 

		offset = gameObject.transform.position -
		         Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
		
		
		//Camera.main.WorldToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
		//Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
		
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed / 5);
		
		transform.rotation = Quaternion.Euler(Mathf.Sin(Time.realtimeSinceStartup) * 3f, Mathf.Sin(Time.realtimeSinceStartup) * 3f, Mathf.Sin(Time.realtimeSinceStartup) * 3f); 

	}

	void OnMouseDrag()
	{
		
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;

		
	}

	void OnMouseUp()
	{

	}
}
