using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class TriangleSceneManager : MonoBehaviour
{
	public GameObject row1, row2; 
	public float timeToMoveCamera; 
	public float timeToLoadNextScene = 30;
	private float time;

	public bool Triangle1, Triangle2; 
	void Start () {
		
		row1.SetActive(true);
		row2.SetActive(true);
	}

	void Update()
	{
		
		time += Time.deltaTime;

		if (Triangle1)
		{
			TriangleOne();
			
		}

		if (Triangle2)
		{
			TriangleTwo(); 
		}
	
	}

	void TriangleOne()
	{
		if (time >= timeToMoveCamera)
		{
			Camera.main.transform.DOMove(new Vector3(Camera.main.transform.position.x, -616f, Camera.main.transform.position.z), 2); 

		}

		
		if (time >= timeToLoadNextScene)
		{
			//NewLevelManagement.lvlManagement.isConditionReached = true; 
			NewLevelManagement.lvlManagement.LoadNextLevel();

		}
		
	}

	void TriangleTwo()
	{
		if (time >= timeToMoveCamera)
		{
			Camera.main.transform.DOMove(new Vector3(Camera.main.transform.position.x, -616f, Camera.main.transform.position.z), 2); 

		}

		
		if (time >= timeToLoadNextScene)
		{
			NewLevelManagement.lvlManagement.LoadNextLevel();

		}
	}
}
