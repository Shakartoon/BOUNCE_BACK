using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
	private Rigidbody2D myRB;
	public float speed; 
	
	void Start ()
	{
		myRB = GetComponent<Rigidbody2D>();
		myRB.velocity = new Vector2(speed, 0);
	}
	
	void Update () {

	}
}
