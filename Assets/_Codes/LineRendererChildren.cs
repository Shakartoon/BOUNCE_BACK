using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererChildren : MonoBehaviour
{
	private LineRenderer myLR;
	private Transform[] pointsArray;
	private CheckSpeed checkSpeed; 
	
	void Start ()
	{
		myLR = GetComponent<LineRenderer>(); 
		pointsArray = transform.GetComponentsInChildren<Transform>();

	}
	
	// Update is called once per frame
	void Update () {
		
		
		myLR.positionCount = pointsArray.Length;
		for (int i = 0; i < pointsArray.Length; i++)
		{
			myLR.SetPosition(i, pointsArray[i].position);

		}

	}
	
	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.CompareTag("Ball"))
		{
			transform.position = new Vector3(1 * Time.time, 1 * Time.time, 0) ;
			
		}
			
	}
}
