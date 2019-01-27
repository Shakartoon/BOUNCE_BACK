using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CollisionRotate : MonoBehaviour {

	public GameObject ball; 

	void Start () {
		
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag("Ball"))
		{
			ball.transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime);

			
		}
		
	}
}
