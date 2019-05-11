using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RugFringeLevelManager : MonoBehaviour
{

	public GameObject levelChanger; 
	public BallMovementScript ballMovement; 
	public float timeToChangeLevel, timeToLoadLevelObj;
	private float time; 
	
	void Start ()
	{
		levelChanger.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		time += Time.deltaTime;

		if (time >= timeToLoadLevelObj)
		{
			
			levelChanger.SetActive(true);

		}
		 	
		if (time >= timeToChangeLevel || ballMovement.levelChangeCollisionHappened)
		{
			NewLevelManagement.lvlManagement.LoadNextLevel();
		}
		//if(line1.GetComponentInChildren<SpriteRenderer>().color == Color.black &&line2.GetComponentInChildren<SpriteRenderer>().color == Color.black && line3.GetComponentInChildren<SpriteRenderer>().color == Color.black
		//&& line4.GetComponentInChildren<SpriteRenderer>().color == Color.black && line5.GetComponentInChildren<SpriteRenderer>().color == Color.black)


	}
}
