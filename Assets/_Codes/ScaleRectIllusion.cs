using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleRectIllusion : MonoBehaviour
{

	public GameObject newRect;
	private GameObject rectClone; 
	private SpriteRenderer SR; 
	
	void Start ()
	{

		//SR = GetComponent<SpriteRenderer>();
		SR = newRect.GetComponent<SpriteRenderer>(); 
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (rectClone.transform.localScale.x > 2.5f)
		{
			//newRect.color = newCol; 
			newRect.transform.localScale += new Vector3( 1, 1, 0); 
			rectClone = Instantiate(newRect, new Vector3(0, 0, 0), Quaternion.identity); 
			newRect.transform.localScale += new Vector3( 1, 1, 0) * Time.time; 
		}

	}
}
