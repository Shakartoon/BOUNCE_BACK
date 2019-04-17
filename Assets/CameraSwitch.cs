using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

	public static bool _CollisionHappened; //Static --> belongs to the static class instead of any instance of the original class - only 1 static variable existing in the whole game 
	private Camera myCamera;
	private float timer = 2f;
	private float time = -1; 

	void Start () {
		
		_CollisionHappened = false;
		myCamera = GetComponent<Camera>(); 
	}
	
	void Update ()
	{

		if (_CollisionHappened)
		{

			myCamera.enabled = true;
			time = 0;
			_CollisionHappened = false;

		}

		if (time >= 0)
		{
			time += Time.deltaTime;
			if (time >= timer)
			{
				time = -1;
				myCamera.enabled = false; 
			}
		}
		
	}
}
