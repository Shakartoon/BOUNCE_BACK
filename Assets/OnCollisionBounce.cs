using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class OnCollisionBounce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter2D()
	{

		if (gameObject.CompareTag("Ball"))
		{
			transform.DOShakeScale(0.3f, new Vector2(0.1f, 0.1f), 2, 1, false);

		}
		
	}
	
}
