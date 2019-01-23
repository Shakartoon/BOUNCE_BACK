using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionShapeAppearRotate : MonoBehaviour
{


	public GameObject bar1;
	public Vector3 bar1Position; 
	public Vector3 bar1Rotation; 

	public GameObject bar2; 
	public Vector3 bar2Position; 
	public Vector3 bar2Rotation;

	private float counter;
	private bool theScreenIsBlack = false; 

	public GameObject blackCircle;
	public GameObject whiteCircle; 
	
	void Start ()
	{

		whiteCircle.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {

		if (counter == 1)
		{
			bar1.transform.SetPositionAndRotation(bar1Position, Quaternion.Euler(bar1Rotation));
			blackCircle.transform.localScale += new Vector3(0.1f * 0.1f, 0.1f * 0.1f, 0);
			if (blackCircle.transform.localScale.x >= 3)
			{
				blackCircle.transform.localScale += new Vector3(0.5f, 1, 0);
				theScreenIsBlack = true; 
			}
			//blackCircle.transform.localScale = Vector3.Lerp(new Vector3(2f, 2f, 0f), new Vector3 (0.2f, 0.2f, 0f), Time.deltaTime * 2f);
			//blackCircle.transform.SetPositionAndRotation(bar1Position, Quaternion.Euler(bar1Rotation));

		}
		
		if (counter == 2)
		{
			bar2.transform.SetPositionAndRotation(bar2Position, Quaternion.Euler(bar2Rotation));
			
		}

		if (theScreenIsBlack)
		{
			whiteCircle.SetActive(true);

		}
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("Ball"))
		{
			counter++; 

		}
		
	}
	
}
