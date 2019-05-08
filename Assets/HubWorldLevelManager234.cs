using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubWorldLevelManager234 : MonoBehaviour
{

	public float inHubWorld2;
	public float inHubWorld3;
	public float inHubWorld4;

	private float time;
	private float timer = 5; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (time >= timer)
		{
			NewLevelManagement.lvlManagement.isConditionReached = true; 
		}
		
	}
}
