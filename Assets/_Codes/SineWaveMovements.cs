using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWaveMovements : MonoBehaviour
{

	float direction;
	float maxLimit, lowerLimit;
	
	void Start()
	{
		maxLimit = transform.position.y + 1;// you set this to your desired height
		lowerLimit = transform.position.y;//this can be whatever you want as well
		direction = -0.01f;// you can put this as any number you want, the larger the number the more it will look like teleporting, the smaller the number the more smooth but the less distance it will travel per frame/time
	}
 
	void FixedUpdate()
	{
		
		//they go in a straight line this way: transform.position = transform.position + new Vector3(direction, 0, 0);

		//Horizontal 
		transform.position = transform.position + new Vector3(0.05f, direction, 0);
		if(transform.position.y >= maxLimit) direction = -0.05f;
		if(transform.position.y <= lowerLimit) direction = 0.05f; 
	}
}