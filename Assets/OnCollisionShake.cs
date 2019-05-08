using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class OnCollisionShake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {
		
		if (col.gameObject.CompareTag("Ball"))
		{
			//DOShakePosition(float duration, float / Vector3 strength, int vibrato,  float randomness,  bool fadeOut)
			transform.DOShakePosition(3, 2, 1, 1f);
			Camera.main.transform.DOShakePosition(3f, 3, 3, 1f);

		}

	}
}
