﻿using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework.Constraints;
using UnityEngine;

public class Drag : MonoBehaviour {

    public bool isRotating;
	public Vector3 screenPoint; 
	public Vector3 offset;
    public float degreesPerSec = 360f;

	public GameObject littleBalls; 
	
	//keetp track of init position 
	private Vector3 intialPosOfLittleBalls;
	public bool _colliderPressed; 

	void Start()
	{
		//InvokeRepeating ("ActivateLittleBalls", 1f, 2f); 

	} 
//	void ActivateLittleBalls(){
//
//		littleBalls.SetActive(true); 
//	}
		
	void Update ()
	{
		//StartCoroutine(activatetheballs()); 

	}


    void OnMouseOver(){
        if (Input.GetMouseButtonDown(1)){
            float rotAmount = degreesPerSec * Time.deltaTime;
            float curRot = transform.localRotation.eulerAngles.z;
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));
        }

		if (Input.GetKeyDown(KeyCode.Z)) {

			Instantiate(this, new Vector3(0, 0, 0), Quaternion.identity);
		}

		if (Input.GetKeyDown (KeyCode.X)) {
		
			Destroy (this); 
		} 
			
    }

    void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		offset =  transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,screenPoint.z));
		_colliderPressed = true; 
	}

	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;

	}

}
