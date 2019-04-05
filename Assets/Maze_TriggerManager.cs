using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_TriggerManager : MonoBehaviour
{

	public bool MazeTrigger1Entered;

	private bool Collision;

	void OnTriggerEnter2D(Collider2D col)
	{

		if (col.gameObject.CompareTag("MazeTrigger1"))
		{
			Collision = true; 
			MazeTrigger1Entered = true;
			Debug.Log("Helpme");

		}
	}
}