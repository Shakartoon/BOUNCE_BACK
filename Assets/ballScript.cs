using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {

	public Vector2 defPos; // Everything you do is about positions. 
	public Rigidbody2D rb; 

	// Use this for initialization
	void Start () {

		rb = GetComponent < Rigidbody2D> (); 
		defPos = transform.position; // This is its current position; these are different values?  

	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < -5f) { 

			transform.position = defPos; 
			rb.velocity = new Vector2 (0, 0); 
				
			// velocity = 0; 


		} 
		
	}
}
