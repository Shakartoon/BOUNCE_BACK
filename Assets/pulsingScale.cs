using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulsingScale : MonoBehaviour
{
	//public float MIN_SCALE = 0.75F;
	//private float scale; 

	public PlayerCollision collisionScript;
	private bool collisionIsTrue = false; 
	
	void Start ()
	{
		collisionScript.CollisionHappened = false; 
	}
	
	// Update is called once per frame
	void Update () {
		
		
		//scale = MIN_SCALE + Mathf.PingPong(Time.time * 0.2f, 1f - MIN_SCALE);
		//transform.localScale = new Vector3(scale, scale, scale);
		
		/*
		Hashtable hash = new Hashtable();
		hash.Add("amount", new Vector3(0.15f, 0.15f, 0f));
		hash.Add("time", 1f);
		iTween.PunchScale(gameObject, hash);
		*/

		if (collisionScript.CollisionHappened)
		{
			collisionIsTrue = true; 

		}

		if (collisionIsTrue)
		{
			Hashtable hash = new Hashtable();
			hash.Add("amount", new Vector3(2f, 2f, 0f));
			hash.Add("time", 1f);
			iTween.PunchScale(gameObject, hash);
				
		} 

	}


	
}
