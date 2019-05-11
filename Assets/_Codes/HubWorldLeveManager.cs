using System.Collections;
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
	public float timer = 4;
	public float timeItTakesToMove, timeTitleMove;
	public Vector3 moveToPosition; 
	private float time;

	public BallMovementScript ballScript; 

	
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

		/* 
		if (time > timer - 3f)
		{
			CameraFollowScript.enabled = false;
			cameraRotateScript.enabled = false; 
			Camera.main.transform.DOMove(moveToPosition, timeItTakesToMove);
			Camera.main.transform.DORotate(new Vector3(4, 0, 0), timeItTakesToMove, RotateMode.Fast); 
		}

		if (time > timer - 1f)
		{
			TitleScreen1.SetActive(true);
			TitleScreen1.transform.DOMove(new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y, Camera.main.transform.position.z), timeTitleMove);
			//Title1ScreenSpriteRenderer.DOColor(new Color (1, 1, 1, 1), 2f); 
			//DontDestroyOnLoad(TitleScreen1);
		}
		*/ 
		if (ballScript.levelChangeCollisionHappened) //levelChangeCollisionHappened)
		{
			CameraFollowScript.enabled = false;
			cameraRotateScript.enabled = false; 
			Camera.main.transform.DOMove(moveToPosition, timeItTakesToMove);
			Camera.main.transform.DORotate(new Vector3(4, 0, 0), timeItTakesToMove, RotateMode.Fast); 
			TitleScreen1.SetActive(true);
			TitleScreen1.transform.DOMove(new Vector3(Camera.main.transform.position.x,Camera.main.transform.position.y, Camera.main.transform.position.z), timeTitleMove);
			NewLevelManagement.lvlManagement.LoadNextLevel(); 
		}
								
	}
}
