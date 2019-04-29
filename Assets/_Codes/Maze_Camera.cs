using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_Camera : MonoBehaviour
{

	public Maze_TriggerManager MTMScript;
	public followPlayer FPScript; 
	private Vector3 position;
	private Quaternion rotation;

	
	void Start()
	{
		position = new Vector3(-31.8f, 044.8f, -22.7f);
		gameObject.GetComponent<CameraPlayerFollow>().enabled = true;

	}
	
	void Update ()
	{		
		if (MTMScript.MazeTrigger1Entered)
		{
			transform.position = position; 
			//transform.rotation = Quaternion.Euler(90, 0, 0);
			gameObject.GetComponent<CameraPlayerFollow>().enabled = false;


		}
		
	}
}
