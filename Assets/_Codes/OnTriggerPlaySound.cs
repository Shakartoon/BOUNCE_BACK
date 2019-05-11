using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPlaySound : MonoBehaviour
{
	private AudioSource AS;
	public bool DestroyOnCollision, RandomizeClips; 
	[SerializeField] bool changePitch;
	public float TimeToDestroy = 2f;
	private SpriteRenderer SR; 
	
	[SerializeField] AudioClip[] audioClips;
	private AudioClip myClip; 
	
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
		
		if (RandomizeClips)
		{
			int index = Random.Range(0, audioClips.Length);
			myClip = audioClips[index];
			AS.clip = myClip; 
			AS.Play();			
		}
	}
}
