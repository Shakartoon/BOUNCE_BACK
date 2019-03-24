using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class OnCollisionFadeDestroy_Mom : MonoBehaviour
{
	private SpriteRenderer mySpriteRenderer;
	private float alpha;
	private float lerpParam; 
	
	
	float decrementValue = 0.01f;
	float colorValue = 1;

	
	void Start ()
	{

		mySpriteRenderer = GetComponent<SpriteRenderer>(); 
	}
	
	void OnCollisionEnter2D (Collision2D col) {
	
		if (col.gameObject.CompareTag("Ball"))
		{
			mySpriteRenderer.DOFade(0, 1.5f); 
			Destroy(gameObject, 1.8f); 
		}
	}
}
