using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnCollision : MonoBehaviour
{

	public GameObject blueSquare; 
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision2D col) {

		if (col.gameObject.CompareTag("Ball"))
		{
			
			blueSquare.animation.Play();
		}
		
	}
}
