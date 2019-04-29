using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionPulse : MonoBehaviour {

	public float approachSpeed = 0.02f;
	public float growthBound = 2f;
	public float shrinkBound = 0.5f;
	private float currentRatio = 1;

	
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag("SoundMakingObject"))
		{
			currentRatio = Mathf.MoveTowards(currentRatio, growthBound, approachSpeed);

			
		}
		
	}
}
