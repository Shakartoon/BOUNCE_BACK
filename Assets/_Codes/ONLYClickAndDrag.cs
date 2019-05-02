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
}
