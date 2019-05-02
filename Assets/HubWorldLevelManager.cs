using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HubWorldLevelManager : MonoBehaviour {

	float m_FieldOfView = 10;
	private bool Collided;
	public Camera mainCamera;
	public CameraPlayerFollow fpScript; //the script that follows the player 
	public GameObject objectZoomIn;

	public static bool Level1Played1; 
	public static bool Level1Played2; 

	
	void Start ()
	{

		fpScript.enabled = true; 
	}
	
	void Update () {

		if (Collided)
		{
			fpScript.enabled = false; 
			
			SceneManager.LoadScene("Triangles"); 
			SceneTracker.me.TimesPlayedLevel1++;
					
			//Camera.main.transform.position = new Vector3(149f, 100f, -23.8f);
			//Camera.main.fieldOfView = m_FieldOfView;
			//SceneTracker.sceneTracker.lastLevelPlayer = 1;
 
			if (SceneTracker.me.TimesPlayedLevel1 > 0)
			{
				Level1Played1 = true; 
			}

			if (SceneTracker.me.TimesPlayedLevel1 > 1)
			{
				Level1Played2 = true; 
			}

			/* 
			float x = Vector3.Distance(Vector3.zero, Camera.main.transform.position);
			float y = height / 2f;
			float requiredFOV = Mathf.Atan(y / x) * Mathf.Rad2Deg;
			Camera.main.fieldOfView = requiredFOV * 2f;
			*/


		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag("Ball"))
		{
			Collided = true; 

		}
	}
}
