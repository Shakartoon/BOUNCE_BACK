using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maze_TriggerManager : MonoBehaviour
{


	public bool FringeCollision; 
	public bool ImmigrationCollision1; 
	public bool EscapeCollision; 
	public bool PapirosCollision;
	public bool TriangleCollision; 


	void Start()
	{

	}
	public void OnTriggerEnter2D(Collider2D col)
	{
		//COLLISION CHECKS LEVELS
		//IMMIGRATION 
		if (col.gameObject.CompareTag("ImmigrationButton"))
		{
			ImmigrationCollision1 = true; 

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