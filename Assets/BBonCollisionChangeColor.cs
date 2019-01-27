using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BBonCollisionChangeColor : MonoBehaviour
{

	public Color lerpedColor;
	private SpriteRenderer SR;
	
	private float timer; 
	
	void Start ()
	{
		SR = GetComponent<SpriteRenderer>(); 
	}


	void Update()
	{
		timer = timer + Time.deltaTime; 

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
			SR.color = Color.white; 

		}
	
	}

}
