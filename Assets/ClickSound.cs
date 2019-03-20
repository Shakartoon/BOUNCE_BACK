using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
	private AudioSource myAS; 
	void Start () {
		
	}
	
	// Update is called once per frame

	void OnMouseEnter()
	{
		if (Input.GetMouseButtonDown(1))
		{

			Debug.Log("t00 easy"); 

		}
		
	}
}
