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
		yield return new WaitForSeconds(1f);
		myFieldOfView += 5f * Time.deltaTime; 

	}
	
	void Update ()
	{
		Camera.main.fieldOfView = myFieldOfView;
		StartCoroutine(Wait()); 
		transform.position = player.transform.position + distance;

		if (myFieldOfView >= 28f)
		{
			StopCoroutine(Wait()); 

			myFieldOfView = 23f; 

		}

	}
}
