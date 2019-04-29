using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
	private Rigidbody2D myRB; 
	void Start ()
	{
		myRB = GetComponent<Rigidbody2D>();
		myRB.velocity = new Vector2(-0.5f, 0);
	}
	
	void Update () {

	}
}
