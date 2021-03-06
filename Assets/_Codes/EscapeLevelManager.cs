﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;
using DG.Tweening; 

public class EscapeLevelManager : MonoBehaviour
{

	public GameObject player, secondDiamond, fourDiamonds;
	public float timer = 8f;
	private Rigidbody2D playerRB;
	private float time;
	private SpriteRenderer[] sprites;
		
	void Start ()
	{

		playerRB = player.GetComponent<Rigidbody2D>(); 
		playerRB.constraints = RigidbodyConstraints2D.FreezePosition;
		sprites = fourDiamonds.GetComponentsInChildren<SpriteRenderer>();

	}
	
	void Update()
	{
		time += Time.deltaTime; 
		
		if(time >= timer)
		{
			Debug.Log(playerRB.gravityScale);
			playerRB.constraints = RigidbodyConstraints2D.None; 
		}

		bool weDone = true;
		for (int i = 0; i < sprites.Length; i++)
		{
			if (sprites[i] != null && sprites[i].color != Color.black)
			{
				weDone = false;
				break;
			}
		}

		if (weDone)
		{
			NewLevelManagement.lvlManagement.LoadNextLevel();
		}
		
		/*if (secondDiamond.GetComponentInChildren<SpriteRenderer>().color == Color.black)
		{	
		  
			//NewLevelManagement.lvlManagement.isConditionReached = true;
			//NewLevelManagement.lvlManagement.LoadNextLevel();

		
			//This is super BUGGY 
			//Player velocity is too damn high 
			//PLUS write a line if player position > camera reposition it 
			
			//Debug.Log("Help Me"); 
			//Ok, this works. 
			//But later on, I want to do this for all the other black-able objects 
			//For now, I'm going to use a timer 


		}*/

	}
}
