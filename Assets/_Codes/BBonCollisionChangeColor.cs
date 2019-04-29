using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBonCollisionChangeColor : MonoBehaviour
{

	public Color lerpedColor;
	private SpriteRenderer SR;
	private Animator AM; 
	
	private float timer;

	public bool Collided = false; 
	
	void Start ()
	{
		SR = GetComponent<SpriteRenderer>();
		AM = GetComponent<Animator>();
	}


	void Update()
	{
		timer = timer + Time.deltaTime;

		if (Collided)
		{
			AM.Play("explosionAnim"); 

		}

	}
	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.CompareTag("SoundMakingObject"))
		{
			//lerpedColor = Color.Lerp(lerpedColor, Color.white, Mathf.PingPong(Time.time, 1));
			//SR.color = lerpedColor; 
			SR.color = Color.black; 
		}

	}

	void OnCollisionExit2D(Collision2D col)
	{
		
		if (col.gameObject.CompareTag("SoundMakingObject") && timer > 1f)
		{
			Collided = true; 
			SR.color = Color.white; 

		}
	
	
	}

}
