using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseScale : MonoBehaviour {

    public float timer; 
    private float time; 
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		time += Time.deltaTime;
		if (time >= timer)
		{
			transform.localScale = new Vector3(Random.Range(0, 7), Random.Range(0, 7), 0); 
			time -= Time.deltaTime; 
		}
		
	}
}
