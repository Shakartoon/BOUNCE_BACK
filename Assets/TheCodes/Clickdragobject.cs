using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickdragobject : MonoBehaviour {

    private Vector2 mousePosition;
    public Vector2 objectPosition;



	void OnMouseOver()
	{

		Debug.Log("Entered"); 
		
	
	}
    void OnMouseDrag()
    {
        objectPosition = mousePosition;
	    transform.localScale = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0); 

    }

	void Update()
	{

		if (gameObject.transform.localScale.x >= 10f)
		{
			
			//Okay, so I can't manipulate sound effects with the audio source because of the objects use sound making object script 
		}
		
	}
}
