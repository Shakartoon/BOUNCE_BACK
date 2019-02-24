using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionPlaySound : MonoBehaviour
{
	private AudioSource AS;
	public bool changePitch;

	public GameObject ballToLoad; 
	
	void Start ()
	{

		AS = GetComponent<AudioSource>(); 
		ballToLoad.SetActive(false);

	}
	
	// Update is called once per frame
	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.CompareTag("Ball"))
		{
			AS.Play();
			if(changePitch)
			{
				AS.pitch = Random.Range(0.1f, 2f);
			}	
			
			ballToLoad.SetActive(true);
			ballToLoad.transform.localScale += new Vector3(0.1f, 0.1f, 0);

			
		}

	}
}
