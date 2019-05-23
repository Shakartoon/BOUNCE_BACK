using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuarrelLevelManager : MonoBehaviour {

	public GameObject player, pink, blue;
	private float time, timer = 2f; 
	
	void Start ()
	{

		player.GetComponent<Rigidbody2D>().isKinematic = true; 
		pink.SetActive(false);
		blue.SetActive(false);


	}
	
	void Update ()
	{
		time += Time.deltaTime; 
		if (time >= timer)
		{
			player.GetComponent<Rigidbody2D>().isKinematic = false; 

		}

		if (time >= timer + 1f)
		{
			pink.SetActive(true);
			blue.SetActive(true);
		}
	}
}
