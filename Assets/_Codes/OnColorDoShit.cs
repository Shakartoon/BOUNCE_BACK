using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColorDoShit : MonoBehaviour
{

	private SpriteRenderer[] SR; 
		

	
	//public GameObject rect1; 
	
	
	void Start ()
	{
		SR = GetComponentsInChildren<SpriteRenderer>();

	}
	
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < SR.Length; i++)
		{
			//if (SR.Length.color = Color.black)
			{
				
				
			}
		}


		//foreach (SpriteRenderer child in SpriteRenderer)
		
	}
}
