using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class TriangleSceneManager : MonoBehaviour
{
	public GameObject row1, row2; 
	public float timeToMoveCamera; 
	public float timeToLoadNextScene = 45;
	private float time; 
	void Start () {
		
		row1.SetActive(true);
		row2.SetActive(true);
	}

	void Update()
	{
		
		time += Time.deltaTime;

		if (time >= timeToMoveCamera)
		{
			Camera.main.transform.DOMove(new Vector3(Camera.main.transform.position.x, -616f, Camera.main.transform.position.z), 2); 

		}

		if (time >= 30)
		{
			row1.SetActive(false);
			row2.SetActive(false);
			
		}
		
		if (time >= timeToLoadNextScene)
		{
			//NewLevelManagement.lvlManagement.isConditionReached = true; 
			NewLevelManagement.lvlManagement.LoadNextLevel();

		}

	} 
}
