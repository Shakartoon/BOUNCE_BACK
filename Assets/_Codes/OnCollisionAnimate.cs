using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class OnCollisionAnimate : MonoBehaviour
{

	public GameObject thisTriangleWillMove;
	private Vector3 startposition;
	private Vector3 endposition; 

	void Start () {
		
		startposition = thisTriangleWillMove.transform.position = new Vector3(13f, -14f, 0f);
		endposition = thisTriangleWillMove.transform.position = new Vector3(13f, -10f, 0f); 
	}

	void moveOnCollision()
	{

	} 
	
	
	void OnCollisionEnter2D (Collision2D col)
	{
		float moveSpeed = 0.5f; 
		float step = moveSpeed * Time.deltaTime; 


		if (col.gameObject.CompareTag("Ball"))
		{

			thisTriangleWillMove.transform.position = Vector3.Lerp(transform.position, endposition, step) * 5f; 
		}
		
	}
}
