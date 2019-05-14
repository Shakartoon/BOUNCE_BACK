using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Audio;

public class PlayerAudio : MonoBehaviour
{
	private AudioSource myAS;
	private AudioMixer myMixer;
	private bool collision;
	private float targetVolume;
	void Start ()
	{

		myAS = GetComponent<AudioSource>(); 
		myMixer = GetComponent<AudioMixer>(); 
	}
	
	void Update ()
	{

		myAS.volume = Mathf.MoveTowards(myAS.volume, targetVolume, Time.deltaTime * 3f);


		targetVolume = Mathf.MoveTowards(targetVolume, 0, .2f * Time.deltaTime);
	}


	
	void OnCollisionStay2D (Collision2D col) {
	
	    if (col.gameObject.CompareTag("Ball"))
	    {
		    targetVolume = 1;

	    }
		
		
	}
}
