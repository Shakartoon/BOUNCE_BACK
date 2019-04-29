using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitchshift : MonoBehaviour
{
	private AudioSource AS;
	
	void Start ()
	{

		AS = GetComponent<AudioSource>(); 
	}
	
	// Update is called once per frame
	void Update ()
	{
		AS.pitch = transform.position.y;
		//AS.Play();

	}
}
