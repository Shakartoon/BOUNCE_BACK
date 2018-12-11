using System.Collections;
using System.Collections.Generic;
using Pixelplacement.TweenSystem;
using UnityEngine;

public class CameraMoveClick : MonoBehaviour
{
	public MousePressed _MousePressed;
	public Vector3 _Position; 

	
	// Use this for initialization
	void Start () {
		_MousePressed._mousePressed = false;
		_MousePressed._mousePressedTwice = false; 
	}
	
	// Update is called once per frame
	void Update ()
	{

		//Vector3 _currentPosition = _Position; 
		
		if (_MousePressed._mousePressed)
		{
			transform.position = Vector3.Lerp (transform.position, new Vector3(0,16.7f, -10), 3f * Time.deltaTime);

		}

		if (_MousePressed._mousePressedTwice)
		{
			transform.position = Vector3.Lerp (transform.position, new Vector3(10,16.7f, -10), 2f * Time.deltaTime);

		}
	}
}
