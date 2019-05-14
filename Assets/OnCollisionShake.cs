using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class OnCollisionShake : MonoBehaviour
{

	public float duration;
	public float strength;
	public int vibrato;
	public float randomness;
	private bool collided; 
	void Start () {
		
	}

	void Update()
	{
		if (collided)
		{
			transform.DOShakePosition(3, 2, 1, 1f);
			Camera.main.transform.DOShakePosition(duration, strength, vibrato, randomness);
		}

	}
	
	void OnCollisionEnter2D (Collision2D col) {
		
		if (col.gameObject.CompareTag("Ball"))
		{
			collided = true; 
		}

	}
}
