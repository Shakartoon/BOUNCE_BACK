﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

	public GameObject firstCircle;
	public Transform target;
	public GameObject InsideCircle; 
	
	private float counter = 0f; 
	
	void Start () {
		
		InsideCircle.SetActive(false);
		
	}

	//NEED to find a more efficient way to do this 
	void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.CompareTag("Ball"))
		{
			counter++; 

		}
		
	}
	
	//Clearly this is a fucked up way of doing this, the audio is super messed up. 
	void Update () {

		float speed = Random.Range(0.5f, 5f); 
		float step = speed * Time.deltaTime;

		if (counter == 1)
		{
			Debug.Log("Hello");
			InsideCircle.SetActive(true);
			//InsideCircle.transform.localScale = new Vector3 (0.1f * 2f, 0.1f * 2f, 0.1f * 2f) * Time.deltaTime; 
			firstCircle.transform.position = Vector3.MoveTowards (transform.position, target.position, step);

		}

		if (counter == 2)
		{
			Instantiate(this, new Vector3(2f, 0.75f, 0), Quaternion.identity); 

		}
		
		if (counter == 3)
		{
			Instantiate(this, new Vector3(-2.77f, 0.75f, 0), Quaternion.identity); 

		}
		
		
	}

	
}
