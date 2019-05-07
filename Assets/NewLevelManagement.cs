using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewLevelManagement : MonoBehaviour
{
	private float timer;
	public float timeToNextScene = 3f; 
	public Maze_TriggerManager triggerScript;

	public bool isConditionReached = false;


	public static NewLevelManagement lvlManagement;
	
	
	void Start ()
	{

		lvlManagement = this;

	}
	
	void Update () {
				//Hub World 1
		// Immigration 1 
		// Rug Fringe 1 
		//Hub World 2
		// Immigration 2 
		// Pap i rose 
		//Hub World 3 
		// Escape 
		// Rug Fringe 2 
		// Phone 

		//if (triggerScript.ImmigrationCollision1)
		//{
		//	SceneManager.LoadScene("Immigration1");
		//}

		//if ()
		//{
		//	SceneManager.LoadScene("RugFringe");

		//}
		
		timer += Time.deltaTime;
/*
		if (timer >= timeToNextScene || Input.GetKey(KeyCode.RightArrow))

		{

			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			timer = 0;
		} 
		
		*/

		if (isConditionReached == true)
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			isConditionReached = false;
		}
		
		
		DontDestroyOnLoad(gameObject);

	}
}
