using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPlaySound : MonoBehaviour
{
	private AudioSource AS;
	public bool DestroyOnCollision; 
	
	void Start ()
	{

		AS = GetComponent<AudioSource>(); 

	}

	void OnTriggerEnter2D (Collider2D col) {
		
		if (col.gameObject.CompareTag("Ball"))
		{
			AS.Play();
		}
		
		if(DestroyOnCollision)
		{
			Destroy(gameObject, 2f);
		}		
	}
}
