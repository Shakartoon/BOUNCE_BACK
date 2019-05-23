using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class ParticlePlayer : MonoBehaviour
{
	public GameObject player;
	private ParticleSystem playerPS;
	public float timeToEmit;

	public bool onPlayer;
	public bool onSoundMakingObject; 
	
	void Awake ()
	{
		playerPS = player.GetComponent<ParticleSystem>();
		playerPS.enableEmission = false;
	}


	void OnCollisionEnter2D(Collision2D col)
	{
		if (onSoundMakingObject)
		{
			if (col.gameObject.CompareTag("Ball"))
			{
				Debug.Log("Collided");
				playerPS.Play();
				//StartCoroutine(stopParticleSystem());

			}
		}		
	}

	IEnumerator stopParticleSystem()
	{
		yield return new WaitForSeconds(timeToEmit); 
		playerPS.enableEmission = true;
	}
	
}
