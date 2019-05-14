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
	void Start ()
	{

		myAS = GetComponent<AudioSource>(); 
		myMixer = GetComponent<AudioMixer>(); 
	}
	
	void Update () {

		if (collision)
		{
			StartCoroutine(AudioLength()); 

		}	
		
	}

	IEnumerator AudioLength()
	{
		myMixer.DOSetFloat("myVolume", 0, 0.1f); 
		yield return new WaitForSeconds(2);
		myMixer.DOSetFloat("myVolume", 3, 0.1f); 
		yield return new WaitForSeconds(0);

		
	}
	
	void OnCollisionEnter2D (Collision2D col) {
	
	    if (col.gameObject.CompareTag("Ball"))
	    {
		    collision = true; 

	    }
		
	}
}
