using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererTest : MonoBehaviour
{
	private LineRenderer myLR;
	private TrailRenderer myTR;

	private Transform[] pointsArray;
	public GameObject[] point = new GameObject[4];
	public GameObject point0;
	public GameObject point1; 
	public GameObject point2; 
	public GameObject point3; 
	
	public Color c1 = Color.yellow;
	public Color c2 = Color.red;

	private float speedA;
	private float lengthA; 

	
	void Start ()
	{

		myLR = GetComponent<LineRenderer>();
		myTR = GetComponent<TrailRenderer>();

		pointsArray = transform.GetComponentsInChildren<Transform>();
		
		float alpha = 1.0f;
		Gradient gradient = new Gradient();
		gradient.SetKeys(
			new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
			new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
		);
		myTR.colorGradient = gradient;

	}

	void Update()
	{

		myLR.positionCount = pointsArray.Length;
		for (int i = 0; i < pointsArray.Length; i++)
		{
			myLR.SetPosition(i, pointsArray[i].position);
			
			//Tried to make an array of the child points, wasn't sure how to do it-- 
			//pointsArray.setPosition = 
			//myLR.transform.position = new Vector3(Random.Range(1, 3), Random.Range(1, 4), 0) * Time.time;

			point0.transform.position = new Vector3(Random.Range(0.1f, 1), Random.Range(0.1f, 1), 0) * Time.time / 5f;
			point1.transform.position = new Vector3(Random.Range(0.1f, 1), Random.Range(0.1f, 1), 0) * Time.time / 5f;
			point2.transform.position = new Vector3(Random.Range(0.1f, 1), Random.Range(0.1f, 1), 0) * Time.time / 5f;
			point3.transform.position = new Vector3(Random.Range(0.1f, 1), Random.Range(0.1f, 1), 0) * Time.time / 5f;
			
				/* 
			
			point0.transform.position = new Vector3(4 * Mathf.Cos(45), 3 * Mathf.Sin(40), 0);
			point1.transform.position = new Vector3(4 * Mathf.Cos(45), 3 * Mathf.Sin(40), 0);
			point2.transform.position = new Vector3(24 * Mathf.Cos(45), 3 * Mathf.Sin(40), 0);
			point3.transform.position = new Vector3(4 * Mathf.Cos(45), 3 * Mathf.Sin(40), 0);

			
				*/

		}
		

			
	}
	

	
} 
