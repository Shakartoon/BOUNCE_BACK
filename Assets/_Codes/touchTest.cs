using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchTest : MonoBehaviour
{
	private Touch myTouch; 
	
	void Start () {
		
	}
	
	void Update ()
	{
		//a variable of an instance of struct? like a class? who the fuck knows 
		// myTouch.fingerId --> identifies unique touch: 
		//myTouch.position --> position of the touch on screen; vector2; screenspace: 
		//myTouch.deltaPosition --> good for movement direction as well as || TAP COUNT, DELTA TIME & PHASE 
		myTouch = Input.GetTouch(0);
		Touch[] _myTouches = Input.touches; 
		//to loop the correct number of times 
		for (int i = 0; i < Input.touchCount; i++) //how does it know what touchCount is 
		{
			
		}
	}
}
