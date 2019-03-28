using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

	public GameObject firstBar;
	public GameObject[] barArray;

	private bool _OnMouseDown; 
	
	void Start () {
		
	}
	
	void Update () {

		if (firstBar.transform.position != Vector3.zero)
		{
			Debug.Log("HasChanged");

			if (_OnMouseDown)
			{
				firstBar.transform.position = Vector3.zero;
			}
			
			// Wait 1 second 
			// Move the bar up 
			// Add some indication juice 
			// Load all the children of red lines parent object and wait a little between each load 
		}
		
	}

	void OnMouseDown()
	{
		_OnMouseDown = true; 
	}
	
}
