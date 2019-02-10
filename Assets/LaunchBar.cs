using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBar : MonoBehaviour {

	private Rigidbody2D my_rb;
	public float rb_force; 
	
	public GameObject myBar; 	
	
	void Start () {
		
		my_rb = GetComponent<Rigidbody2D>();
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject == myBar)
		{
			my_rb.AddForce(new Vector2(0, rb_force));
			
		}
		
		
	}

}
