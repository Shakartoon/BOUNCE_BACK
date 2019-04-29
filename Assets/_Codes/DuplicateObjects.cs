using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateObjects : MonoBehaviour
{
	private bool isDuplicated = false; 
		
	void Start () {
		
		
	}

	void OnMouseUp()
	{

		if(Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.LeftShift))
		{

			isDuplicated = true; 
			print("ID = " + isDuplicated);
		}
		
	}

	void Update() //Constantly detecting mouse click 
	{

		if (isDuplicated)
		{
			if (Input.GetMouseButtonDown(0))
			{
				Vector2 ScreenPosition = Input.mousePosition;
				Vector3 WorldPosition = Camera.main.ScreenToWorldPoint(ScreenPosition);
				WorldPosition.z = 0;
								
				Instantiate(gameObject, WorldPosition, Quaternion.Euler(0,0,transform.eulerAngles.z)); //<-- Vector2 that we need to transform to world position 
				isDuplicated = false;
				print("ID = " + isDuplicated);
			}
			
		}

	}
}
