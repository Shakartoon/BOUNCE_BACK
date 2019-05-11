using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ONLYClickAndDrag : MonoBehaviour
{

	//Make it public but not viewable in inspector
	public bool _OnMouseDown;
	public bool _OnMouseDrag;
	public bool _OnMouseUp; 
	private Vector3 offset;

	public bool thisCollisionHappened; 
	public bool thishappened; 
	
	void OnMouseDown()
	{
		offset = gameObject.transform.position -
		         Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));

	}

	void OnMouseDrag()
	{
		
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
		
	}

	void OnMouseUp()
	{
		_OnMouseUp = true; 
	}

	void Update()
	{
		if(thishappened)
		{
			thisCollisionHappened = true;
		}
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("LevelChanger"))
		{
			thishappened = true; 
		
		}
		
	}
}
