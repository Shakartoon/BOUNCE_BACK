using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HubWorldLevelManager : MonoBehaviour {
	
	public Maze_TriggerManager MTM; 
	
	void Start ()
	{

	}
	
	void Update () {
			
			//SceneTracker.me.TimesPlayedLevel1++;
					
			//Camera.main.transform.position = new Vector3(149f, 100f, -23.8f);
			//Camera.main.fieldOfView = m_FieldOfView;
			//SceneTracker.sceneTracker.lastLevelPlayer = 1;
 
			if (SceneTracker.me.TimesPlayedLevel1 > 0)
			{
			}

			if (SceneTracker.me.TimesPlayedLevel1 > 1)
			{
				
			}

			/* 
			float x = Vector3.Distance(Vector3.zero, Camera.main.transform.position);
			float y = height / 2f;
			float requiredFOV = Mathf.Atan(y / x) * Mathf.Rad2Deg;
			Camera.main.fieldOfView = requiredFOV * 2f;
			*/


		if (MTM.FringeCollision)
		{
			SceneManager.LoadScene("RugFringe");
			
		}

		if (MTM.ImmigrationCollision)
		{
			SceneManager.LoadScene("Immigration1");

		}

		if (MTM.EscapeCollision)
		{

			SceneManager.LoadScene("NewEscape");

		}
	}
}
