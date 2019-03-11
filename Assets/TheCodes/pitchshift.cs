using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitchshift : MonoBehaviour
{
	private AudioSource AS;
	public GameObject ball; 
	
	void Start ()
	{

		AS = GetComponent<AudioSource>(); 
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		//Pseudo code 
		
		// convert the position of ball to pitch values 
		// if the ball is touching the bar and is on one end 
		// change pitch to position and play 
		//	ball.transform.position); 


	}
}
