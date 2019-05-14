using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerFollow : MonoBehaviour {

	public Transform target;

	public float smoothSpeed = 0.125f;
	public float zOffset; 
	public Vector3 offset;
	private Vector3 smoothedPosition;
	public Transform smoothedTarget;
	void Start()
	{
		smoothedPosition = transform.position;
		smoothedTarget.position = target.position;
	}
	
	void LateUpdate ()
	{
		Vector3 desiredPosition = target.position + offset;
		smoothedPosition = Vector3.Lerp(smoothedPosition, desiredPosition, smoothSpeed + zOffset);
		transform.position = smoothedPosition + new Vector3(0, 0, zOffset); 
			
		smoothedTarget.position = Vector3.Lerp(smoothedTarget.position, target.position, smoothSpeed + zOffset);
		transform.LookAt(smoothedTarget);
	}

}﻿
