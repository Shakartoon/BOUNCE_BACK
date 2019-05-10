using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoiseMover : MonoBehaviour {

	public float minx, maxX, minY, maxY, zValMin, zValMax; 
    public float timer; 
    float time;

	public GameObject object2Follow; 
	public bool automatic, followObject; 
	void Start () {
		
	}
	
	void Update ()
	{

		time += Time.deltaTime; 
		if (time >= timer)
		{
			if(automatic)
			{
				//transform.localPosition = new Vector2(Random.Range(-4.3f, 2f), Random.Range(2.3f, 5.6f));
				transform.localPosition = new Vector3(Random.Range(minx, maxX), Random.Range(minY, maxY),
					Random.Range(zValMin, zValMax));
				time = 0;
			}

			if (followObject)
			{
				transform.localPosition = new Vector3(object2Follow.transform.position.x + Random.Range(1, 5), object2Follow.transform.position.y + Random.Range(1, 5), 65);
				
			}
		} 
		
		

	}
}
