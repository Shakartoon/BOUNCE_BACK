using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionColorChange : MonoBehaviour
{

	float decrementValue = 0.1f;
	float colorValue = 1;

	private SpriteRenderer SR;  

	
	void Start ()
	{

		SR = GetComponent<SpriteRenderer>();
	}
	
	void OnCollisionEnter2D (Collision2D col) {

		
		if (col.gameObject.CompareTag("Ball"))
		{
			colorValue -= decrementValue;
			if (colorValue > 0)
				SR.color = new Color(colorValue, colorValue, colorValue);
			else
				SR.color = Color.black;

		}

	}

}
