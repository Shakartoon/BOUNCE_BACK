using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{

	float timeBetweenSpawns;
	public float startTimeBetweenSpawns;

	public GameObject echo; 
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (timeBetweenSpawns <= 0)
		{
			Instantiate(echo, transform.position, Quaternion.identity);
			timeBetweenSpawns = startTimeBetweenSpawns; 
		}

		else
		{
			timeBetweenSpawns -= Time.deltaTime; 
		}
		
	}
}
