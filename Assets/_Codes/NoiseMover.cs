using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMover : MonoBehaviour {

	public float minx, maxX, minY, maxY; 
    public float timer; 
    float time;

	void Start () {
		
	}
	
	void Update ()
	{

		time += Time.deltaTime; 
		if (time >= timer)
		{
			//transform.localPosition = new Vector2(Random.Range(-4.3f, 2f), Random.Range(2.3f, 5.6f));
			transform.localPosition = new Vector2(Random.Range(minx, maxX), Random.Range(minY, maxY));
			time = 0; 
		} 

	}
}
