using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternScales : MonoBehaviour
{

	public bool scaleIt;
	public bool rotateIt; 
	
	public float speed = 2f; 
	
	private Vector3 initialScale;
	private Vector3 newScale; 
	
	void Start ()
	{
		
		newScale = new Vector3(3, 3, 0);
		initialScale = new Vector3(0.5f - 1, 0.5f - 1, 0);

	}
	
	void Update ()
	{

		MakeItBigger();
		RotateIt(); 

	}
		
	void RotateIt()
	{
		if (rotateIt)
		{
			
			float rude = Mathf.Deg2Rad;
			//transform.localEulerAngles = new Vector3(0, 0, rude * 25f) * Time.deltaTime * speed; 
			//transform.RotateAround(Vector3.left, Vector3.down * 4f, 20 * Time.deltaTime * 20f);
			transform.Rotate(new Vector3(0, 0, 20f) * Time.deltaTime, Space.World);

		}
		
	}

	void MakeItBigger()
	{
		
		if (scaleIt)
		{
			transform.localScale = Vector3.Lerp(transform.localScale, newScale, speed * Time.deltaTime);
		
			if (transform.localScale.x >= 2f)
			{
				transform.localScale = Vector3.Lerp(transform.localScale, initialScale, speed * Time.deltaTime);
				transform.localScale = Vector3.zero;
			}
		}
		
	}

}
