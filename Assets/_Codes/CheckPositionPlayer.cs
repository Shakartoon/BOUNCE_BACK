using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPositionPlayer : MonoBehaviour
{
	private Rigidbody myRB; 
	void Start ()
	{
		myRB = GetComponent<Rigidbody>(); 
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < -3.5f)
		{
			transform.position = new Vector3(0, 1, 0);
			myRB.velocity = Vector3.zero; 
		}
	}
}
