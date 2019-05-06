using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze_TriggerManager : MonoBehaviour
{

	public GameObject MazeTrigger2;
	private SpriteRenderer MT2SR; 
	public bool MazeTrigger1Entered;

	public bool FringeCollision; 
	public bool ImmigrationCollision; 
	public bool EscapeCollision; 
	public bool PapirosCollision;
	public bool TriangleCollision; 


	void Start()
	{
		MT2SR = MazeTrigger2.GetComponent<SpriteRenderer>(); 

	}
	public void OnTriggerEnter2D(Collider2D col)
	{

		if (col.gameObject.CompareTag("MazeTrigger1"))
		{
			MazeTrigger1Entered = true;

		}

		if (col.gameObject.CompareTag("MazeTrigger2"))
		{
			Debug.Log(MT2SR.color); 
			MT2SR.color = Color.white; 
		}

		//COLLISION CHECKS LEVELS
		//IMMIGRATION 
		if (col.gameObject.CompareTag("ImmigrationButton"))
		{
			ImmigrationCollision = true; 
		}
	
		//RUG FRINGE  
		if (col.gameObject.CompareTag("RugFringeButton"))
		{
			FringeCollision = true; 
		}
		
		//PAPIROS  
		if (col.gameObject.CompareTag("PapirosObject"))
		{
			PapirosCollision = true; 
		}
		
		//ESCAPE  
		if (col.gameObject.CompareTag("EscapeButton"))
		{
			EscapeCollision = true; 
		}
		
		//TRIANGLE  
		if (col.gameObject.CompareTag("TriangleObject"))
		{
			TriangleCollision = true; 
		}
	}
}