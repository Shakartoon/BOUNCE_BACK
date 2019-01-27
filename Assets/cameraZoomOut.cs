using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoomOut : MonoBehaviour
{
	private bool zoomedIn = true;
	public OnCollisionChangeColorAndBreak collisionColorScript; 
	
	void Start ()
	{

		collisionColorScript.allBlack = false; 

	}


	private IEnumerator Delay()
	{

		yield return new WaitForSeconds(10f); 
	}
	
	void Update () {

		//Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, zoom, Time.deltaTime * smooth); 
		
		if (zoomedIn)
		{
			Camera.main.orthographicSize = 2f;
			Camera.main.transform.position = new Vector3(0.5f, 1.01f, -10f);
		} 

		
		//if (Input.GetMouseButtonDown(0))
		
		//if (collisionColorScript.counter >= 4)
		
		if(collisionColorScript.allBlack)

		{
			StartCoroutine(Delay()); 
			Camera.main.orthographicSize = 5f;
			Camera.main.transform.position = new Vector3(0, 0f, -10f);
			zoomedIn = !zoomedIn; 
		}
	
	}
}
