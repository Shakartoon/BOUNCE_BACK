using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempCollision : MonoBehaviour
{
	private AudioSource AS; 
	void Start ()
	{

		AS = GetComponent<AudioSource>(); 

	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag("Ball"))
		{
			
			AS.Play();
		}
		
	
		
	}
}
