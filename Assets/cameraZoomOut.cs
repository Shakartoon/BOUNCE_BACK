using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoomOut : MonoBehaviour
{
	private bool zoomedIn = true;
	private OnCollisionChangeColorAndBreak collisionColorScript; 
	void Start ()
	{


	}
	
	// Update is called once per frame
	void Update () {

		//Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, zoom, Time.deltaTime * smooth); 
		
		if (zoomedIn)
		{
			Camera.main.orthographicSize = 2f;
			Camera.main.transform.position = new Vector3(0.5f, 1.01f, -10f);
		} 

		
		//if (Input.GetMouseButtonDown(0))
		
		if (collisionColorScript.counter >= 4)
			
		{
			Debug.Log("Awesome");
			Camera.main.orthographicSize = 5f;
			Camera.main.transform.position = new Vector3(0, 0f, -10f);
			zoomedIn = !zoomedIn; 
		}
	
	}
}
