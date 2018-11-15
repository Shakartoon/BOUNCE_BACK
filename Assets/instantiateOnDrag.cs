using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateOnDrag : MonoBehaviour {

	private Vector3 mousePos;
	public GameObject ball;  

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

			Instantiate (ball); 
		} 

		
	}
}
