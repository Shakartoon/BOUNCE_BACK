using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionPlaySound : MonoBehaviour
{
	private AudioSource AS;
	public bool changePitch;

	public GameObject ballToLoad; 
	
	
	private float maxForceForVolume = 10.0f;
	private float minForceForVolume = 0.1f;

	private float maxScreenSize = 30f;
	private float minScreenSize = 1f; 
	
	void Start ()
	{

		AS = GetComponent<AudioSource>();
		ballToLoad.SetActive(false); 

	}

	void Update()
	{
		

	}
	
	void OnCollisionEnter2D (Collision2D col) {
		
		if (col.gameObject.CompareTag("Ball"))
		{
			var force = col.relativeVelocity.magnitude;
			force = Mathf.Clamp(force, minForceForVolume, maxForceForVolume);
			force = force / maxForceForVolume;
			AS.volume = force;
			
			
			float pitchFloat = transform.position.y / maxScreenSize;
			AS.pitch = pitchFloat;
			
			AS.Play();
			
			if(changePitch)
			{
				AS.pitch = Random.Range(0.1f, 2f);
				

			}	
			
			ballToLoad.SetActive(true);
			ballToLoad.transform.localScale += new Vector3(0.1f, 0.1f, 0);

			
		}

	}
}
