using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnCollision : MonoBehaviour
{

	public GameObject blueSquare;
	public bool CollidedWithBall = false;
	private Animator anim; 
	
	void Start ()
	{

		anim = GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag("Ball"))
		{

			CollidedWithBall = true; 
		}

		if (CollidedWithBall)
		{
			anim.Play("BlueSquareAnimation");

		}
		
	}
}
