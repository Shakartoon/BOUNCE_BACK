using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1 : MonoBehaviour
{

	public GameObject ball1; 
	public GameObject ball2; 
	public GameObject ball3; 

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (ball1.transform.position.y > -16 || ball2.transform.position.y > -16 || ball3.transform.position.y > -16)
		{

			//Camera.main.backgroundColor = Color.black; 

		}
	
	}
}
