using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionChangeColorAndBreak : MonoBehaviour
{
	private SpriteRenderer SR;  
	private Color lerpedColor = Color.cyan;
	public float counter = 0;
	
	float decrementValue = 0.1f;
	float colorValue = 1;

	
	void Start ()
	{

		SR = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {

		//Check and wait until ALL FOUR squares have been collided with to change color 
		
		if (col.gameObject.CompareTag("Ball"))
		{
			counter++;
			colorValue -= decrementValue;
			SR.color = new Color(colorValue,colorValue, colorValue);

		}

	}

	void Update()
	{

		if (SR.color == Color.black)
			{
			
				Debug.Log("COlor is Blackkk");
			}
		//if (GameObject.FindGameObjectsWithTag("box").GetComponent<SpriteRenderer>.Color = color.Black)
		
	}

}
