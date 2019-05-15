using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RugFringeLevelManager : MonoBehaviour
{

	public GameObject levelChanger; 
	public BallMovementScript ballMovement; 
	public float timeToChangeLevel, timeToLoadLevelObj;
	private float time;
	public Transform[] lines;
	public SpriteRenderer[][] spriteArrArr;
	private bool weDone, allAreBlack;  
	
	void Start ()
	{
		levelChanger.SetActive(false);
		spriteArrArr = new SpriteRenderer[lines.Length][];

		for (int i = 0; i < lines.Length; i++)
		{
			spriteArrArr[i] = lines[i].GetComponentsInChildren<SpriteRenderer>();
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		time += Time.deltaTime;

		if (time >= timeToLoadLevelObj)
		{
			
			levelChanger.SetActive(true);

		}
		 	
		bool weDone = true;
		for (int i = 0; i < spriteArrArr.Length; i++)
		{
			if (!weDone)
				break;
			for (int j = 0; j < spriteArrArr[i].Length; j++)
			{
				if (spriteArrArr[i][j].color != Color.black)
				{
					weDone = false;
					break;
				}
			}
		}
		
		if (weDone) 											// time >= timeToChangeLevel || ballMovement.levelChangeCollisionHappened)
		{
			NewLevelManagement.lvlManagement.LoadNextLevel();
		}
		//if(line1.GetComponentInChildren<SpriteRenderer>().color == Color.black &&line2.GetComponentInChildren<SpriteRenderer>().color == Color.black && line3.GetComponentInChildren<SpriteRenderer>().color == Color.black
		//&& line4.GetComponentInChildren<SpriteRenderer>().color == Color.black && line5.GetComponentInChildren<SpriteRenderer>().color == Color.black)


	}
}
