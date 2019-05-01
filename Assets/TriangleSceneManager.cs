using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSceneManager : MonoBehaviour {

	void Start () {
		
	}
	
	void Update ()
	{
		if (SceneTracker.me.TimesPlayedLevel1 > 1) //LevelManager15.Level1Played2)
		{
			Debug.Log("Number Two");
			Camera.main.backgroundColor = Color.black; 
		}

	}
}
