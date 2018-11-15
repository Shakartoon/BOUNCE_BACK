using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {


	public IEnumerator Shake (float duration, float magnitude) {

		//Original Camera Position 
		Vector3 originalPosition = transform.localPosition; 
		//how much time has elapsed since we started shaking 
		float elapsed = 0.0f; 

		while (elapsed < duration) {
			float x = Random.Range (-0.05f, 2f) * magnitude; 
			float y = Random.Range (-0.05f, 2f) * magnitude; 
			transform.localPosition = new Vector3 (x, y, originalPosition.z); 
			elapsed += Time.deltaTime; 
			yield return null; 
		}

		transform.localPosition = originalPosition; 
	}



}
