using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubWorldLevelManager234 : MonoBehaviour
{

	public float inHubWorld2;
	public float inHubWorld3;
	public float inHubWorld4;

	private float time;
	public float timer = 10f; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		time += Time.deltaTime; 
		if (time >= timer)
		{
			time = 0;
			NewLevelManagement.lvlManagement.isConditionReached = true; 
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			NewLevelManagement.lvlManagement.LoadLevel("Triangles");
		}

	}
}
