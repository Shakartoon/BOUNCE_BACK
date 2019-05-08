using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class HubWorldLevelChanges : MonoBehaviour {

	//This script alters the hub world only, before and after it changes scenes 

	public GameObject player, backgroundFlower, random1, random2; 
	float timer = 4;
	private float time; 

	void Start () {
		
		backgroundFlower.SetActive(false);
		//random1.SetActive(false);
		//random2.SetActive(false);
		float time;
	}
	
	void Update ()
	{
		time += Time.deltaTime;
		
		if (time > timer)
		{
			NewLevelManagement.lvlManagement.isConditionReached = true;
			time = 0; 

		}
		
		//AFTER IMMIGRATION #1 
	
		
		/* 
		if (SceneTracker.me.TimesPlayedTriangle == 1)
		{
			backgroundFlower.SetActive(true);

		}*/ 
		
		/*

		if (SceneTracker.me.TimesEnteredHubWorld == 1)
		{
			backgroundFlower.SetActive(true);
			player.transform.DOMove(new Vector3(90, 11, 0), 3); 

		}

		if (SceneTracker.me.TimesEnteredHubWorld == 2)
		{
			Camera.main.backgroundColor = Color.white;
			//random1.SetActive(true);


		}
		
		if (SceneTracker.me.TimesEnteredHubWorld == 3)
		{
			Camera.main.backgroundColor = Color.yellow;
			//random2.SetActive(true);
			//random1.SetActive(false);



		}

		
		//AFTER IMMIGRATION #2
		
		
		//AFTER RUG FRINGE #1
		
		
*/ 
		
	}
}
