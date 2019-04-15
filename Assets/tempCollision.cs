using System.Collections;
using System.Collections.Generic;
using EZCameraShake;
using UnityEngine;

public class tempCollision : MonoBehaviour
{

	private AudioSource AS;
	[HideInInspector] public bool collisionOccured = false;
	private CameraShaker CamShake;
	public GameObject circleToExpand;

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
			Debug.Log("Volume: " + AS.volume);

			var force = col.relativeVelocity.magnitude;
			force = Mathf.Clamp(force, minForceForVolume, maxForceForVolume);
			force = force / maxForceForVolume;

			AS.volume = force;
			
			collisionOccured = true; 
			
			//What is all this stuff? 
			CameraShaker.Instance.ShakeOnce (1f, 2f, 0f, 2f);
			circleToExpand.transform.localScale += new Vector3(transform.localScale.x * 20f, 50, 0) * Time.deltaTime; 
		}
		
	}
}
