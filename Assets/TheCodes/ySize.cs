using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ySize : MonoBehaviour
{
	private Vector3 defScale;
	public float yScale;
	public float xScale;

	public bool rightScale;
	public bool ScaleMe; 

	
	void Start ()
	{
		defScale = transform.localScale; 

	}
	
	void Update () {

		//transform.localScale += new Vector3(2F, 2, 0);
		
		if (ScaleMe)
		{
			defScale = new Vector3(xScale, yScale, 0) * Time.deltaTime;
			transform.localScale += defScale;
		}

		if (rightScale)
		{
			Vector3 newScale = transform.localScale;
			newScale.x *= 0.1f;
			transform.localScale += newScale;

			if (transform.localScale.x >= 10f)
			{
				transform.localScale = Vector3.zero; 

			}

		}
	}
}
