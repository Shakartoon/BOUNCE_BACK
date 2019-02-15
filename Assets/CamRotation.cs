using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation : MonoBehaviour
{

	private float desiredRot;
	public float rotSpeed = 250;
	public float damping = 10;

	private Quaternion originalRotationValue;
	private float rotationResetSpeed = 10f;

	private bool firstCoRoutineClick; 
	private bool secondCoRoutineClick; 

	
	void Start()
	{
		originalRotationValue = transform.rotation;
		desiredRot = transform.eulerAngles.z;

	}
	
	private IEnumerator CamRotate()
	{
	
		firstCoRoutineClick = false; 
		
		while (enabled)
		{

			yield return new WaitForSeconds(5);
			firstCoRoutineClick = true;

			if (firstCoRoutineClick)
			{
				if (Input.GetMouseButton(0))
				{
					if (Input.mousePosition.x > Screen.width / 2) desiredRot -= rotSpeed * Time.deltaTime;
					else desiredRot += rotSpeed * Time.deltaTime;
				}

				var desiredRotQ = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, desiredRot);
				transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotQ, Time.deltaTime * damping);
			} 

			yield return new WaitForSeconds(10);
			transform.rotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * rotationResetSpeed);
			yield return null;
		}
	}


	public void CameraRotation()
	{
		StartCoroutine(CamRotate());

	}	
	
	
	private void Update()

	{
		StartCoroutine(CamRotate());
		//Start a timer and STATE VARIABLE to tell whether waiting for the game initial 5 seconds or whether the screen is rotating or has stopped 

	}
}  