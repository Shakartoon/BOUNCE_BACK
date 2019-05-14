using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingMovement : MonoBehaviour {


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		transform.localPosition = Vector3.left * Time.deltaTime;
		if (transform.localPosition.x >= 25f)
		{
			transform.localPosition = Vector3.right * Time.deltaTime; 
		}

		if (transform.position.x >= 20)
		{
			transform.localPosition = Vector3.left * Time.deltaTime; 
		}

	}
}
