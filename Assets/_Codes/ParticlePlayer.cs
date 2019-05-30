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
		if (player != null)
		{
			playerPS = player.GetComponent<ParticleSystem>();
			playerPS.enableEmission = false;
		}
	}


	void OnCollisionEnter2D(Collision2D col)
	{
		if (onSoundMakingObject)
		{
			if (col.gameObject.CompareTag("Ball"))
			{
				Debug.Log("Collided");
				if (playerPS != null)
					playerPS.Play();
				//StartCoroutine(stopParticleSystem());

			}
		}		
	}

	IEnumerator stopParticleSystem()
	{
		yield return new WaitForSeconds(timeToEmit); 
		if (playerPS != null)
			playerPS.enableEmission = true;
	}
	
}
