using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
	private float degree; 
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		float rad = Mathf.Rad2Deg;
		transform.localEulerAngles = new Vector3(5, 5, rad) * Time.time; 

	}
}
