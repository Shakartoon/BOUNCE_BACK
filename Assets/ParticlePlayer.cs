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
	
	// Update is called once per frame
	void OnMouseDown () {

		if (Input.GetMouseButtonDown(0))
		{

			myPS.Play(); 
		}
	}
}
