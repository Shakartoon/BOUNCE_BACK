using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollsionBall : MonoBehaviour
{
	private Vector2 startingPosition;

	void Awake()
	{
		startingPosition.x = transform.position.x; 

	}
	
	void Start () {
		
	}


	void Update()
	{
		
		startingPosition.x += Mathf.Sin(Time.deltaTime * 5.0f) * 5.0f; 

	}
	
	
	void OnCollisionEnter2D (Collision2D col) {
	
	    if (col.gameObject.CompareTag("SoundMakingObject"))
	    {

		    Debug.Log("Make life okay"); 
		    startingPosition.x += Mathf.Sin(Time.deltaTime * 5.0f) * 5.0f; 

	    }
		
	}
}
