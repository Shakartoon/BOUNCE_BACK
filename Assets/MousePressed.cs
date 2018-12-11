using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePressed : MonoBehaviour {


	public bool _mousePressed;
	public bool _mousePressedTwice; 

	//public Vector3 screenPoint; 
	//public float _speed;

	//public Vector3 _currentPosition;

	//public Vector3 _newPosition; 
	// Use this for initialization
	void Start ()
	{
		_mousePressed = false;
		_mousePressedTwice = false; 
	}
	
	// Update is called once per frame
	void OnMouseOver() {
		
		if (Input.GetMouseButtonDown(0))
		{
			_mousePressed = true; 		
			
			//screenPoint = Camera.main.WorldToScreenPoint(transform.position);
			//Camera.main.transform.position = Vector3.Lerp (transform.position, new Vector3(0,16.5f, -10), 10f);
			if (Input.GetMouseButtonDown(1))
			{
				_mousePressedTwice = true;
				Debug.Log("PRESSED 2");
			} 

		}


	}
}
