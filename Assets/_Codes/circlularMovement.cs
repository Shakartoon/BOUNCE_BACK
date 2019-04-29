using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlularMovement : MonoBehaviour {

	public float timeCounter = 0; 

	public float speed = 5; 
	public float width = 4; 
	public float height = 7; 

	private float x; 
	private float y; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timeCounter += Time.deltaTime * speed; 

		x = Mathf.Cos(timeCounter)*width ; 
		y = Mathf.Sin(timeCounter)*height ; 

		transform.position = new Vector3 (x, y, 0); 
		
	}
}
