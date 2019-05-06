using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubWorldLevelChanges : MonoBehaviour {

	//This script alters the hub world only, before and after it changes scenes 

	public GameObject backgroundFlower; 
	void Start () {
		
		backgroundFlower.SetActive(false);
	}
	
	void Update () {

		//AFTER IMMIGRATION #1 
		
		if (SceneTracker.me.TimesPlayedTriangle == 1)
		{
			backgroundFlower.SetActive(true);

		}

		if (SceneTracker.me.TimesPlayedTriangle == 2)
		{
			backgroundFlower.SetActive(false);

		}
		
		//AFTER IMMIGRATION #2
		
		
		//AFTER RUG FRINGE #1
		
		

		
	}
}
