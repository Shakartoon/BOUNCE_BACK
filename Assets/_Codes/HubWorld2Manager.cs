using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubWorld2Manager : MonoBehaviour
{

	public BallMovementScript ballScript; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if (ballScript.levelChangeCollisionHappened)
		{
			NewLevelManagement.lvlManagement.LoadNextLevel();
		}

		
	}
}
