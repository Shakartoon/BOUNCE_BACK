using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Serialization;

public class PapirosLevelManager : MonoBehaviour {

	//temporary conditions
	private float timer = 3f; 
	private float time;
	private int CameraMoves;

	public float moveTime; 
	public Vector3 position1, position2, position3, position4, position5, position6;

	public BallMovementScript moveScript;
	
	void Start () {
		
	}
	
	void Update () {

		//move camera in a sequence 

		if (Camera.main.transform.position == position1)
		{
			if (moveScript.PapirosCollisionCount == 1) 
			{
				Camera.main.transform.DOMove(position2, moveTime);
			}
		} 
		
		if (Camera.main.transform.position == position2)
		{
			if (moveScript.PapirosCollisionCount == 2) 
			{
				Camera.main.transform.DOMove(position3, moveTime);
			}
		} 
		
		if (Camera.main.transform.position == position3)
		{
			if (moveScript.PapirosCollisionCount == 3) 

			{
				Camera.main.transform.DOMove(position4, moveTime);
			}
		} 
		
		if (Camera.main.transform.position == position4)
		{
			if (moveScript.PapirosCollisionCount == 4) 
			{
				Camera.main.transform.DOMove(position5, moveTime);
			}
		} 
		
		if (Camera.main.transform.position == position5)
		{
			if (moveScript.PapirosCollisionCount == 5) 
			{
				Camera.main.transform.DOMove(position6, moveTime);
				NewLevelManagement.lvlManagement.isConditionReached = true; 
			}
		}
	}
}
