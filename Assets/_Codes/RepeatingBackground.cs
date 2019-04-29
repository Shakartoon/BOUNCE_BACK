using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
	private BoxCollider2D collider;
	private float length; 
	void Start ()
	{
		collider = GetComponent<BoxCollider2D>();
		length = collider.size.x; 
	}
	
	void Update () {

		if (transform.position.x < -length * 0.4f)
		{
			RepositionBackground();
		}
		
	}

	void RepositionBackground() //calculates how far it has to move and moves it 
	{
		Vector3 offset = new Vector3(length * 0.5f, 0, transform.position.z); // double the length of the collider and jump our object past the visible one 
		transform.position = (Vector3) transform.position + offset; 
	}
}
