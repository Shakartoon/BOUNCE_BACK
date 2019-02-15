using System.Collections;
using System.Collections.Generic;
using EZCameraShake;
using UnityEngine;

public class tempCollision : MonoBehaviour
{
	private AudioSource AS;
	public bool collisionOccured = false;
	private CameraShaker CamShake;
	public GameObject circleToExpand; 
	
	
	void Start ()
	{

		AS = GetComponent<AudioSource>(); 

	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag("Ball"))
		{
			
			AS.Play();
			collisionOccured = true; 
			CameraShaker.Instance.ShakeOnce (1f, 2f, 0f, 2f);
			
			circleToExpand.transform.localScale += new Vector3(transform.localScale.x * 20f, 50, 0) * Time.deltaTime; 
		}
		
	}
}
