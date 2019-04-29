using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class EscapeLevelManager : MonoBehaviour
{

	public GameObject player;
	public float timer = 5f;
	private Rigidbody2D playerRB;
	private float time; 
		
	void Start ()
	{

		playerRB = player.GetComponent<Rigidbody2D>(); 
		playerRB.isKinematic = true; 

	}
	
	void Update()
	{
		time += Time.deltaTime; 
		if(time >= timer)
		{
			playerRB.isKinematic = false;
		}
	}
}
