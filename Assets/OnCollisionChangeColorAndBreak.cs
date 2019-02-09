using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionChangeColorAndBreak : MonoBehaviour
{
	public float counter = 0;
	float decrementValue = 0.1f;
	float colorValue = 1;

	private SpriteRenderer SR;  
	public SpriteRenderer[] AllSR; 

	public bool allBlack = false;
	public bool CollisionHappened = false; 

	
	void Start ()
	{

		SR = GetComponent<SpriteRenderer>();
		AllSR[4] = GetComponent<SpriteRenderer>(); 
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {

		//Check and wait until ALL FOUR squares have been collided with to change color 
		
		if (col.gameObject.CompareTag("Ball"))
		{
			counter++;
			colorValue -= decrementValue;
			SR.color = new Color(colorValue, colorValue, colorValue);
		}

	}

	
	void Update()
	{

		if (SR.color == Color.black)
		{
			Debug.Log("Color is Blackkk");
		}


		for (int i = 0; i < AllSR.Length; i++)
		{
			if (SR.color == new Color (0, 0, 0, 1))
			{
				Debug.Log("THIS FUCKING WORKS!!!");
				allBlack = true; 
				Destroy(gameObject, 3f);
			}

		}
	}

}
