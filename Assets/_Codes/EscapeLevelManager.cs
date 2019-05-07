using System.Collections;
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
	public bool thisWorls; 
		
	void Start ()
	{

		playerRB = player.GetComponent<Rigidbody2D>(); 
		playerRB.constraints = RigidbodyConstraints2D.FreezePosition;   


	}
	
	void Update()
	{
		time += Time.deltaTime; 
		
		if(time >= timer)
		{
			Debug.Log(playerRB.gravityScale);
			playerRB.constraints = RigidbodyConstraints2D.None; 
			
			//Increase int 
			//Change Level 
		}

		//if (lastDiamond.GetComponentInChildren<SpriteRenderer>().color == Color.black)
		if (secondDiamond.GetComponentInChildren<SpriteRenderer>().color == Color.black)
		{
			thisWorls = true; 
			
		    //Debug.Log("Help Me"); 
			//Ok, this works. 
			//But later on, I want to do this for all the other black-able objects 
			//For now, I'm going to use a timer 
			
			//SceneTracker.me.TimesEnteredHubWorld++;

			NewLevelManagement.lvlManagement.isConditionReached = true;

			//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

			//SceneManager.LoadScene("Hub World");

			//This is super BUGGY 
			//Player velocity is too damn high 
			//PLUS write a line if player position > camera reposition it 

		}

	}
}
