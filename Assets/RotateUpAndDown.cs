using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUpAndDown : MonoBehaviour
{

	[SerializeField] private bool startRotation; 
		
	void Start () {
		if (startRotation)
		{
			transform.rotation = Quaternion.Euler(0, 360, 0);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
		//make a full rotation 
		
		transform.rotation = Quaternion.Euler(Mathf.Sin(Time.realtimeSinceStartup) * 3, 0, 0);
			
		
		
	}
}
