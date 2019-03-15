using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

	public Vector3 camPos = Vector3.zero;
	public Transform target; 
	public bool camDown; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
		Vector3 originalPos = new Vector3(2.87f, -6.7f, -49.15f);
		Vector3 newPos = new Vector3(transform.position.x, -62.7f, transform.position.z); 
		
		
		
		
	}
}
