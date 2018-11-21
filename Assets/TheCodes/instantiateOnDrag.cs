using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class instantiateOnDrag : MonoBehaviour {

	private Vector3 mousePos;
	public GameObject ball; 
	private Vector3 worldPos; 
	public GameObject ballClone; 
	public newSoundMakingObject newSoundMakingObjectScript;
	public Vector3 autoSpawnBallPosition;
	private float autoSpawnTimerGap; //the gap between the time / THE TIME BETWEEN 
	private float autoSpawnTimer; // a running timer
	bool isRecordingTime; //true -- we are recording the time // or using it / playing back 
	
	private Vector3 spawnPosition; 

	// Use this for initialization
	void start () {

		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0f); 
	}
	
	// Update is called once per frame

	public IEnumerator instantiateTheBalls(){
	
		yield return new WaitForSeconds (1); 
	//	Destroy (objectInstance); 
	}

	void MoveByExample () {

		//THIS DOESN'T WORK: 
		iTween.MoveBy (this.gameObject, iTween.Hash ("position", new Vector3 (1, 1, 0), "time", 2f, "easetype", iTween.EaseType.easeInOutBack)); 

	}

	void OnMouseDrag() {
		//short term variable and long term to store the position when the L Key is down 

		spawnPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition); 
		spawnPosition.z = 0.0f; 
		ballClone = (GameObject) Instantiate (ball, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;


	}

	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			spawnPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition); 
			spawnPosition.z = 0.0f; 
			
			ballClone = (GameObject) Instantiate (ball, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
	    	//Keep track of last instantiated object 
		
			//IF R BUTTON PRESSED, STORE AND REPEAT THE INSTANTIATE POSITION 
			// IF C BUTTON PRESSED, CLEAR IT 

		} 
		
		if (Input.GetKey(KeyCode.L)) 
		{
			//starts to record when mouse button clicked 
			if (Input.GetMouseButtonDown (0))
			{
				// tell it where to instantiate the ball and how long till the next 
				// here we store / we know where to spawn for the loop 
				
				//This is WHERE the ball will instantiate- at the location we set earlier at the mouse position. 
				autoSpawnBallPosition = spawnPosition; 
				
				//Now we know that we are keeping track of the time the player hit the button to record it. 
				isRecordingTime = true;
				
				//Not sure 
				autoSpawnTimerGap = 0f; // prepare for the recording of time 
				Debug.Log("description");
			}

			if (isRecordingTime == true)
			{
				//keep recording 
				autoSpawnTimerGap = autoSpawnTimerGap + Time.deltaTime;  //ad value and give result back to it (= this plus something) 
                //will automatically stop on release 
			}

		}

		if (Input.GetKeyUp(KeyCode.L))
		{
			isRecordingTime = false; 
	
		}
		
		// We need a timer; doesn't care about recording or setup, just keeps trying to instantiate a new ball 
		if (autoSpawnTimerGap > 0) { 
			//set a legal value or pattern for auto spawn
			// do the auto spawn - increase the value of the running timer 
			//the timer increases - if it hits the auto spawn time gap - means we've passed a certain amount of time and have to instantiate new one 
			autoSpawnTimer = autoSpawnTimer + Time.deltaTime;
			if (autoSpawnTimer >= autoSpawnTimerGap)
			{
				//time to instantiate a new ball 
				ballClone = (GameObject) Instantiate (ball, autoSpawnBallPosition, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
				autoSpawnTimer = 0; 

			}

		}		

		//IF MOUSE DRAGGED, CREATE A NEW BALL AT EVERY X/Y LOCATION EVERY ~0.5 SECONDS 



	  if (newSoundMakingObjectScript.myCollision = true) {

			//ERROrS: It's not seeing *this* collision && destroying ENTIRE game object. 

			//StartCoroutine (instantiateTheBalls ()); 
			// DESTROY OBJECT AFTER
			//transform.position = Vector3.Lerp (startPosition, endPosition, 1f); 
		
			
		Destroy (ballClone, 0.5f); 


		}
		

	}
	
}
