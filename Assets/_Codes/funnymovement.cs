using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnymovement : MonoBehaviour {

	public Transform from;
	public Transform to;
	public float speed = 0.1F;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
				
		Vector3 randompoint = new Vector3 (Random.Range(-1,4),Random.Range(-7,7 ), 0);

		gameObject.transform.position=Vector3.Lerp(gameObject.transform.position,randompoint,Time.deltaTime*1f);

		gameObject.transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.time * speed);
	
		
		
		/* 
		
		transform.Translate(new Vector3(-1, -1, 0) * Time.time);

		if (transform.position.y > -3f)
		{
			
			transform.Translate(new Vector3(1, 0, 0) * Time.time);
		}

		if (transform.position.y < -8.5f)
		{
			float move = 1f; 
			transform.Translate(new Vector3(1, move++, 0) * Time.time);

		}
		
		*/ 
	}
}
