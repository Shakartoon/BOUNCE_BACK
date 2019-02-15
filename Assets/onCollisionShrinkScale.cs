using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollisionShrinkScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(3f); 
		transform.localScale -= new Vector3(5f, 5f, 0);
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.CompareTag("Ball"))
		{
			StartCoroutine(Wait()); 
		}

	}
}
