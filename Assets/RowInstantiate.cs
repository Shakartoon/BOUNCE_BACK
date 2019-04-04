using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RowInstantiate : MonoBehaviour {

	public Transform pointPrefab; 
	public Vector3 InitialViewportPos;
	public int Count;
	public float Distance;
	
	void Awake()
	{
		for (int i = 0; i < Count; i++) {

			Transform point = Instantiate(pointPrefab,Vector3.zero, Quaternion.Euler(new Vector3(0, 0, 90)));
			point.position = Camera.main.ViewportToWorldPoint(InitialViewportPos + new Vector3(i * Distance, 0));
		}   
	   

	}
}
