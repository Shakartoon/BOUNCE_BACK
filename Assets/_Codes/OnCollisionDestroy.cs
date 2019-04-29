using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroy : MonoBehaviour {

	public GameObject instObj; 
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("Ball"))
		{
			//not working 
			Destroy(instObj);
		}
		
	}
	
	
}
