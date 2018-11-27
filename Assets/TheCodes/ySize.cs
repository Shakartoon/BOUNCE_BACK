using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ySize : MonoBehaviour
{
	private Vector3 defScale; 

	// Use this for initialization
	void Start ()
	{
		defScale = transform.localScale; 

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//transform.localScale += new Vector3(2F, 2, 0);
		defScale = new Vector3(0.1f, 0.1f, 0.1f); 
	}
}
