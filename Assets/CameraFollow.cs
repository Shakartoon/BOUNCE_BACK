using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


	public GameObject player;
	Vector3 distance;

	private float myFieldOfView; 
		
	void Start ()
	{

		myFieldOfView = 0.5f; 
		distance = transform.position - player.transform.position; 
	}


	IEnumerator Wait()
	{

		yield return new WaitForSeconds(0.5f); 
		Camera.main.fieldOfView = myFieldOfView; 
		

		
	}
	
	void Update ()
	{

		transform.position = player.transform.position + distance; 

	}
}
