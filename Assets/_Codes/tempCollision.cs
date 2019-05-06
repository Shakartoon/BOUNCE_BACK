using System.Collections;
using System.Collections.Generic;
using EZCameraShake;
using UnityEngine;

public class tempCollision : MonoBehaviour
{

	private AudioSource AS;
	public bool collisionOccured = false;
	private CameraShaker CamShake;

	private float maxForceForVolume = 18.0f;
	private float minForceForVolume = 1.0f;

	private CheckSpeed speedCheck;  
	
	void Start ()
	{

		AS = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag("Ball"))
		{
			collisionOccured = true; 
			AS.Play();
			//AS.volume = speedCheck.speed;
//			Debug.Log("Volume: " + AS.volume);

			var force = col.relativeVelocity.magnitude;
			force = Mathf.Clamp(force, minForceForVolume, maxForceForVolume);
			force = force / maxForceForVolume;

			AS.volume = force;

			CameraSwitch._CollisionHappened = true; 
			//any object using this script 
		}
		
	}
}
