using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPlaySound : MonoBehaviour
{
	private AudioSource AS;
	public bool DestroyOnCollision; 
	[SerializeField] bool changePitch;
	public float TimeToDestroy = 2f;
	private SpriteRenderer SR; 

	
	void Start ()
	{

		AS = GetComponent<AudioSource>();
		SR = GetComponent<SpriteRenderer>();
		SR.enabled = true; 

	}

	void OnTriggerEnter2D (Collider2D col) {
		
		if (col.gameObject.CompareTag("Ball"))
		{
			AS.Play();		
			if(DestroyOnCollision)
			{
				SR.enabled = false; 
				Destroy(gameObject, TimeToDestroy);
			}	
		}
		
		if(changePitch)
		{
			AS.pitch = Random.Range(0.5f, 1f);
				
		}
	}
}
