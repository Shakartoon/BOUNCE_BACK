using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class EscapeLevelManager : MonoBehaviour
{

	public GameObject player;
	public float timer = 8f;
	private Rigidbody2D playerRB;
	private float time;
		
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

		}
	}
}
