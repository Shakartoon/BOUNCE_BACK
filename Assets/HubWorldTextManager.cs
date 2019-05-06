using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HubWorldTextManager : MonoBehaviour
{

	public Maze_TriggerManager mtm;
	public TMP_Text ImmigrationText1; 
	
	void Start ()
	{

		ImmigrationText1.GetComponent<TMP_Text>();
		ImmigrationText1.enabled = false; 

	}
	
	void Update () {

		//This Doesn't Work 
		DontDestroyOnLoad(ImmigrationText1);

		if (mtm.ImmigrationCollision)
		{
			ImmigrationText1.enabled = true; 
			
		}
		
	}
}
