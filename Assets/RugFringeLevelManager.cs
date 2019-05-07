using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class RugFringeLevelManager : MonoBehaviour
{
	private float time; 
	private float timer = 5f; 
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		time += Time.deltaTime;
		if (time >= timer)
		{
			
			SceneManager.LoadScene("Hub World 3");
			
		}
		
		/*
		if(SceneTracker.me.TimesPlayedRugFringe == 0)
		{
			time += Time.deltaTime;
			if (time >= timer)
			{
				Debug.Log("Time");
				SceneTracker.me.TimesEnteredHubWorld++;
				SceneTracker.me.TimesPlayedRugFringe++;
				SceneManager.LoadScene("Hub World");

			}
		}
		
		if(SceneTracker.me.TimesPlayedRugFringe == 1)
		{
			time += Time.deltaTime;
			if (time >= timer)
			{
				Debug.Log("MOST");
				SceneTracker.me.TimesEnteredHubWorld++;
				SceneTracker.me.TimesPlayedRugFringe++;
				SceneManager.LoadScene("Hub World");

			}
		}
	*/ 
		
	}
}
