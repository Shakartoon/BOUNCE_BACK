using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
	private BoxCollider2D collider;
	private float length;
	public float xMaxPos;
	public float newxPosition;
	public float xSpeed; 
	

	void Start()
	{
		collider = GetComponent<BoxCollider2D>();
		length = collider.size.x;
	}

	void Update()
	{
		transform.Translate(xSpeed, 0, 0);
		
		if (transform.localPosition.x <= xMaxPos)
		{
			transform.localPosition = new Vector3(newxPosition, transform.localPosition.y, transform.localPosition.z); 
		}
	}

} 

/*
if (transform.position.x < -length * 2f)
{
	RepositionBackground();
}

}

void RepositionBackground() //calculates how far it has to move and moves it 
{
Vector2 offset = new Vector2(length * 0.5f, 0); // double the length of the collider and jump our object past the visible one 
transform.position = (Vector2) transform.position + offset; 
}
} 
*/ 

