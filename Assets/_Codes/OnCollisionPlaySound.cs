﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class OnCollisionPlaySound : MonoBehaviour
{
	private AudioSource AS;

	[SerializeField] private bool RandomizeClips; 
	[SerializeField] private bool UseAudioID;
	[SerializeField] public bool volumeForce; 
	[SerializeField] bool changePitch;
	[SerializeField] AudioClip[] audioClips;
	private AudioClip myClip; 
	
	private float maxForceForVolume = 10.0f;
	private float minForceForVolume = 0.1f;

	private float maxScreenSize = 30f;
	private float minScreenSize = 1f;

	public bool collidedWithBall; 

	public int AudioID;
	public float minTimeBetweenSounds;
	private float lastSoundTime;
	void Start ()
	{

		AS = GetComponent<AudioSource>();

	}


	public void YourVoiceWhenYouCallMeNow()
	{

		
	}
	
	
	void OnCollisionEnter2D (Collision2D col) {
		
		if (col.gameObject.CompareTag("Ball"))
		{
			if (Time.timeSinceLevelLoad - lastSoundTime < minTimeBetweenSounds)
				return;
			lastSoundTime = Time.timeSinceLevelLoad;
			AS.Play();
			
			if (RandomizeClips)
			{
				int index = Random.Range(0, audioClips.Length);
				myClip = audioClips[index];
				AS.clip = myClip; 
				AS.Play();			
			}

			if (volumeForce)
			{
				var force = col.relativeVelocity.magnitude;
				force = Mathf.Clamp(force, minForceForVolume, maxForceForVolume);
				force = force / maxForceForVolume;
				AS.volume = force;	
			}
			/*
			else if (UseAudioID)
			{
				int index = AudioID % audioClips.Length;
				myClip = audioClips[index];
				AS.clip = myClip; 
				AS.Play();		
			}
			else
			{
				AS.Play();
			}
			*/ 			
			if(changePitch)
			{
				AS.pitch = Random.Range(0.5f, 1.5f);
				//float pitchFloat = transform.position.y / maxScreenSize;
				//AS.pitch = pitchFloat;

			}	
			
		
			
		}

	}
}
