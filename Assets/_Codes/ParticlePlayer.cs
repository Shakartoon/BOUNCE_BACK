using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
	private ParticleSystem myPS; 
	
	void Start ()
	{

		myPS = GetComponent<ParticleSystem>(); 
	}


	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.CompareTag("PSObject"))
		{

			myPS.Play(); 

		}
		
	}
	
}
