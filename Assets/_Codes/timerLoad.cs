using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerLoad : MonoBehaviour
{

	public float targetTime; 
	public GameObject rect2;
	
	void Start ()
	{

		rect2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{

		targetTime -= Time.deltaTime;
		
		if (targetTime <= 0f)
		{
			
			Debug.Log("timer");
			rect2.SetActive(true);
		}
		
	}
}
