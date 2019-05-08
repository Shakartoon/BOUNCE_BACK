﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class HubWorldLeveManager : MonoBehaviour {

	//This script alters the hub world only, before and after it changes scenes 

	public GameObject player, backgroundFlower, random1; 


	public CameraPlayerFollow CameraFollowScript;
	public Rotate cameraRotateScript; 
	public GameObject TitleScreen1; 

	//Temporary Timer to change scene 
	float timer = 4;
	private float time;
	
	void Start ()
	{

		CameraFollowScript.enabled = true; 
		cameraRotateScript.enabled = true; 
		TitleScreen1.SetActive(false);
		backgroundFlower.SetActive(false);
	}
	
	void Update ()
	{
		time += Time.deltaTime;
		backgroundFlower.SetActive(true);

		if (time > 2f)
		{
			CameraFollowScript.enabled = false;
			cameraRotateScript.enabled = false; 
			Camera.main.transform.position = new Vector3(58, 6.6f, -25.9f);
			TitleScreen1.SetActive(true);
			//DontDestroyOnLoad(TitleScreen1);
		}
		
		if (time > timer)
		{
			NewLevelManagement.lvlManagement.isConditionReached = true;
			time = 0; 
		}
								
	}
}
