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
	private Vector3 autoSpawnBallPosition;
	private float autoSpawnTimerGap; //the gap between the time / THE TIME BETWEEN 
	private float autoSpawnTimer; // a running timer
	bool isRecordingTime; //true -- we are recording the time // or using it / playing back 
	
	private Vector3 spawnPosition;
	public float minTimeforInstantiate;
	private Drag _dragScript;
	private bool mouseIsDragging; 
	
	//List to store autospawntimegap 
	private List<SpawnerState> _spawnerStateList;
	private List<float> _ballSpawnTimeGapList; //time between pressing and letting go/ ball spawning action 
	private List<Vector3> _ballSpawnPositionList;
	private List<float> _ballSpawnTimer; 

	private List<bool> _spawnerIsWorkingList;
	public Transform[] ballClones;

	enum SpawnerState //state variable for the possible states the spawner is currently in //defines it like a float or something 
	{
		WaitForNumKeyPress, 
		WaitForMouseButtonPress,
		WaitForMouseButtonRelease,
		WaitForNumKeyRelease,
	}
	
	// Use this for initialization
	void Start () {

		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0f);
		_ballSpawnTimeGapList = new List<float>(); 
		_ballSpawnPositionList = new List<Vector3>();
		_spawnerStateList = new List<SpawnerState>();
		_spawnerIsWorkingList = new List<bool>();
		_ballSpawnTimer = new List<float>();
		ballClones = new Transform[10];
		for (int i = 0; i < 10; i++) {
			_ballSpawnTimeGapList.Add(0);
			_ballSpawnPositionList.Add(Vector3.zero);
			_spawnerStateList.Add( SpawnerState.WaitForNumKeyPress);
			_spawnerIsWorkingList.Add(false); 
			_ballSpawnTimer.Add(0);
		}
	}
	
	// Update is called once per frame

	void MoveByExample () {

		//THIS DOESN'T WORK: 
		iTween.MoveBy (this.gameObject, iTween.Hash ("position", new Vector3 (1, 1, 0), "time", 2f, "easetype", iTween.EaseType.easeInOutBack)); 

	}

	void OnMouseDrag() {
		//short term variable and long term to store the position when the L Key is down 

		if (mouseIsDragging = true)
		{
			spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			spawnPosition.z = 0.0f;
			ball.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.black); 
			ballClone = (GameObject) Instantiate(ball, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
			//trying to change the color. of course nothing fucking worked 
		} 
	
		//here I want to stop instantiating the ball if the collider is pressed 
		if (_dragScript._colliderPressed = true)
		{
			//didn't do shit 
			mouseIsDragging = false; 
		
		}

	}
	//only true if key pressed after mouse up 

	void BallSpawnerUpdate(int index) //inside of the world only knows index - the i doesn't exist anymore, it becomes the index 
	{
		switch (_spawnerStateList[index]) //switch based on current state of spawner 
		{
			case SpawnerState.WaitForNumKeyPress:

				if (Input.GetKeyDown(KeyCode.Alpha0 + index))
				{
					_spawnerIsWorkingList[index] = false;
					_spawnerStateList[index] = SpawnerState.WaitForMouseButtonPress;
					if (ballClones[index] != null)
						Destroy(ballClones[index]);
				} 
				break;
				
			case SpawnerState.WaitForMouseButtonPress:
				if (Input.GetKey(KeyCode.Alpha0 + index) == false)
				{
					_spawnerStateList[index] = SpawnerState.WaitForNumKeyPress;
					break; //break out of the switch  
				}
				
				if (Input.GetMouseButtonDown(0))
				{
					// tell it where to instantiate the ball and how long till the next 
					// here we store / we know where to spawn for the loop 
				
					//This is WHERE the ball will instantiate- at the location we set earlier at the mouse position. 
					_ballSpawnPositionList[index] = spawnPosition;

					_ballSpawnTimeGapList[index] = 0;
					_spawnerStateList[index] = SpawnerState.WaitForMouseButtonRelease;
				} 

				break;
			
			case SpawnerState.WaitForMouseButtonRelease:
				_ballSpawnTimeGapList[index] += Time.deltaTime;
				
				if (Input.GetKey(KeyCode.Alpha0 + index) == false)
				{
					_spawnerStateList[index] = SpawnerState.WaitForNumKeyPress;
					break; 
				}

				if (Input.GetMouseButton(0) == false)
				{
					_spawnerStateList[index] = SpawnerState.WaitForNumKeyRelease;
				}
				break;
			
			case SpawnerState.WaitForNumKeyRelease: // 
				_ballSpawnTimeGapList[index] += Time.deltaTime;

				if (Input.GetKey(KeyCode.Alpha0 + index) == false)
				{
					_spawnerIsWorkingList[index] = true;
					_spawnerStateList[index] = SpawnerState.WaitForNumKeyPress;
				}
				break;
		}
	}

	void ActualBallSpawn(int index)
	{
		if (_spawnerIsWorkingList[index])
		{
			//set a legal value or pattern for auto spawn
			// do the auto spawn - increase the value of the running timer 
			//the timer increases - if it hits the auto spawn time gap - means we've passed a certain amount of time and have to instantiate new one 
			//autoSpawnTimer = autoSpawnTimer + Time.deltaTime;
			_ballSpawnTimer[index] = _ballSpawnTimer[index] + Time.deltaTime; 
			
			if (_ballSpawnTimer[index] >= _ballSpawnTimeGapList[index])
			{
				//time to instantiate a new ball 
				ballClone = Instantiate (ball, _ballSpawnPositionList[index], Quaternion.Euler(new Vector3(0, 0, 0)));
				
				//this is what Gabe did! 
				if (ballClones[index] != null)
					Destroy(ballClones[index].gameObject); 
				ballClones[index] = ballClone.transform;
				_ballSpawnTimer[index] = 0; 
			}
		}

	}
	void Update () {

		//BASIC SPAWNING CODE 
		if (Input.GetMouseButtonDown (0)) {
			spawnPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition); //a possible spawn position
			spawnPosition.z = 0.0f; 
			ballClone = Instantiate (ball, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
			Destroy (ballClone, 3f); 

	  
		}

		for (int i = 0; i < 9; i++)
		{
			BallSpawnerUpdate(i); 
			ActualBallSpawn(i); 
		}
		
		if (newSoundMakingObjectScript.myCollision = true) {
			
			Destroy (ballClone, 5f); 

		}

		return;
		
		
		
		
		
		
		if (Input.GetKey(KeyCode.Alpha1)) 
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

		if (Input.GetKeyUp(KeyCode.Alpha1))
		{
			isRecordingTime = false; 
	
		}
		
		// We need a timer; doesn't care about recording or setup, just keeps trying to instantiate a new ball 
		//the time the player sets 
		if (autoSpawnTimerGap > minTimeforInstantiate) { 
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
		//////////////////////////////

		if (Input.GetKey(KeyCode.Alpha2)) 
		{
			if (Input.GetMouseButtonDown (0))
			{
				autoSpawnBallPosition = spawnPosition; 
				isRecordingTime = true;
				autoSpawnTimerGap = 0f; 
				Debug.Log("description");
			}

			if (isRecordingTime == true)
			{
				autoSpawnTimerGap = autoSpawnTimerGap + Time.deltaTime;   
			}

		}

		if (Input.GetKeyUp(KeyCode.Alpha2))
		{
			isRecordingTime = false; 
	
		}
		
		if (autoSpawnTimerGap > minTimeforInstantiate) { 
			autoSpawnTimer = autoSpawnTimer + Time.deltaTime;
			if (autoSpawnTimer >= autoSpawnTimerGap)
			{
				ballClone = (GameObject) Instantiate (ball, autoSpawnBallPosition, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
				autoSpawnTimer = 0; 

			}

		}		

		
		
	
		//////////////////////////////	

	  if (newSoundMakingObjectScript.myCollision = true) {

			//ERROrS: It's not seeing *this* collision && destroying ENTIRE game object. 

			//StartCoroutine (instantiateTheBalls ()); 
			// DESTROY OBJECT AFTER
			//transform.position = Vector3.Lerp (startPosition, endPosition, 1f); 
		
			
		Destroy (ballClone, 1.5f); 


		}
		

	}
	
}
