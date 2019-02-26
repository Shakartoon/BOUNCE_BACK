using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
//a tag that makes it easier to organize 

public class TrigExample : MonoBehaviour
{
	//not going to call it radius, but just the length of a line that happens to be a radius 
	public float lengthA;
	public float speedA; 
	public float lengthB = 4;
	public float speedB = 2;
	public float lengthC = 2;
	public float speedC = 3;

	public GameObject trailObj; 
	
	
	//you can't re-dimension an array once you know it's size in unity - use if you know how many points you have 
	//lists are better - an array that you can add and erase elements from 

	private List<Vector3> positionList = new List<Vector3>(); 
	private LineRenderer myLine;


	void Start()
	{

		myLine = GetComponent<LineRenderer>();
		//myLine.positionCount = Random.Range(1, 20);
		//myLine.SetPosition( )
		//Clear the array 
	
		myLine.positionCount = 0;
		positionList.Add(Vector3.zero); //Always set the origin, the first point, to 0.  
		positionList.Add(Vector3.zero);		
		positionList.Add(Vector3.zero);		
		positionList.Add(Vector3.zero);

	}

	void Update()
	{
		/*
		positionList[1] = PointOnCircle(Time.time * speedA, lengthA);
		positionList[2] = positionList[1] + PointOnCircle(Time.time * speedB, lengthB);
		positionList[3] = positionList[2] + PointOnCircle(Time.time * speedC, lengthC);
		
		positionList[2] = new Vector3(0, 5, 0) * lengthB;
		UpdatePoints();
		*/ 
		//trailObj.transform.position = positionList[positionList.Count - 1]; 
		
		//This didn't do anything 

		lengthA = Random.Range(0.2f, 2f) * Time.time; 
		myLine.transform.position = PointOnCircle(Time.time * speedA / Mathf.PI, lengthA * Mathf.Sin(2)) / 2; 


		//positionList.Add(PointOnCircle(Mathf.PI/4f, lengthA));
		//positionList.Add(new Vector3(2f, 5f, 4f));

	}

	void UpdatePoints()
	{
		//check position count of lines and set them 
		myLine.positionCount = positionList.Count; 
		myLine.SetPositions(positionList.ToArray()); // like to string 

	}
	

	Vector3 PointOnCircle(float angle, float radius)
	{
		return new Vector3(radius * Mathf.Cos(angle), radius * Mathf.Sin(angle), 0);
	}

} 