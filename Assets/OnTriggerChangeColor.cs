using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerChangeColor : MonoBehaviour
{
	private SpriteRenderer SR; 
	
	void Awake ()
	{

		SR = GetComponent<SpriteRenderer>(); 
		SR.color = Color.black;

				
	}


	IEnumerator WaitALil()
	{
		yield return new WaitForSeconds(5f);
		
	}
	
	void OnTriggerEnter2D (Collider2D col) {

		/*
		if (col.gameObject.CompareTag("Ball") && Camera.main.WorldToScreenPoint(transform.position).x > Screen.width / 2)
		{
		
			SR.color = Color.black;
			
		}

		else
		{
			
			SR.color = Color.black;

		}
		*/

		StartCoroutine(WaitALil()); 
		
		if (col.gameObject.CompareTag("Ball")) 
		{
		
			SR.color = Random.ColorHSV();
			
		}

		else
		{
			
			SR.color = Color.black;

		}
		
	}

	void OnTriggerExit2D(Collider2D col)
	{

			SR.color = Color.black;
			
	}
}
