using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RugFringeLevelManager : MonoBehaviour
{

	public GameObject tileObj1, tileObj2;
	public float TimeToMoveTitleObjs, timeToChangeLevel;
	private float time; 
	
	void Start ()
	{
		tileObj1.GetComponent<moveAcrossScreen>().enabled = false; 
		tileObj2.GetComponent<moveAcrossScreen>().enabled = false; 
	}
	
	// Update is called once per frame
	void Update ()
	{

		time += Time.deltaTime;
		if (time >= TimeToMoveTitleObjs)
		{
			tileObj1.GetComponent<moveAcrossScreen>().enabled = true; 
			tileObj2.GetComponent<moveAcrossScreen>().enabled = true; 
		}

		if (time >= 5)
		{
			NewLevelManagement.lvlManagement.LoadNextLevel();
		}

	}
}
