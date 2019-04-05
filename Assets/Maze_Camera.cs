using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_Camera : MonoBehaviour
{

	public Maze_TriggerManager MTMScript; 
	
	void Update () {

		if (MTMScript.MazeTrigger1Entered)
		{
			Debug.Log("This happened");
		}
		
	}
}
