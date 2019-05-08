using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSceneManager : MonoBehaviour
{
	private float timer = 5;
	private float time; 
	void Start () {
		
	}

	void Update()
	{
		
		time += Time.deltaTime;
		
		if (time >= timer)
		{
			NewLevelManagement.lvlManagement.isConditionReached = true; 
		}

	} 
}
