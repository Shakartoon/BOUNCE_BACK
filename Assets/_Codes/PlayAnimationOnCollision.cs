using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationOnCollision : MonoBehaviour
{

	public bool SMAnimation;
	public bool ballAnimation; 
	public GameObject blueSquare;
	public bool CollidedWithBall = false;
	private Animator anim; 
	
	void Start ()
	{

		anim = GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {

		if (SMAnimation)
		{
			if (col.gameObject.CompareTag("Ball"))
			{

				CollidedWithBall = true;
				anim.Play("BlueSquareAnimation");
			}
		}

		if (ballAnimation)
		{
			if (col.gameObject.CompareTag("SoundMakingObject"))
			{
				anim.Play("flair4");
	
			}
		}


		}
		
}

