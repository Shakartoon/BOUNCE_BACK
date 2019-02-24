using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPlaySound : MonoBehaviour
{
	private AudioSource AS; 
	
	void Start ()
	{

		gameObject.SetActive(false);
		AS = GetComponent<AudioSource>(); 

	}

	IEnumerator WaitToActivate()
	{

		yield return new WaitForSeconds(5f);
		gameObject.SetActive(true);

	}

	void Update()
	{
		
		StartCoroutine(WaitToActivate()); 

	}
	
	
	void OnTriggerEnter2D (Collider2D col) {
		
		if (col.gameObject.CompareTag("Ball"))
		AS.Play();
		Destroy(gameObject, 2f);
		
	}
}
