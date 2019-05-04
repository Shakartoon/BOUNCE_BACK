using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening; 


public class HubWorldLevelManager : MonoBehaviour {
	
	public Maze_TriggerManager MTM;
	[HideInInspector] public bool ExitingLevel; 
	
	public GameObject player;
	private Rigidbody2D playerRB;

	public GameObject overlayScreen;
	private SpriteRenderer overlaySR; 
	
	private float timer  = 2f;
	private float time; 
	
	public float m_Hue;
	public float m_Saturation;
	public float m_Value;

	//public CameraShaker cameraShakeScript; ??????? 
	//ShakeOnce
 
	void Start ()
	{
		playerRB = player.GetComponent<Rigidbody2D>();
		overlaySR = overlayScreen.GetComponent<SpriteRenderer>(); 
		overlayScreen.SetActive(false);
	}
	
	void Update ()
	{
		//Camera.main.backgroundColor = Color.HSVToRGB(m_Hue, m_Saturation, m_Value);

			//CameraSaturationValue(); 
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
			playerRB.isKinematic = true;
			ExitingLevel = true; //to access color correction curves script //need one for entering level 
			overlayScreen.SetActive(true);
			time += Time.deltaTime; 
			
			if(time >= timer) 
			{
				SceneManager.LoadScene("RugFringe");
				time = 0; 
			}			
		}

		if (MTM.ImmigrationCollision)
		{
			ExitingLevel = true; 
			playerRB.isKinematic = true;
			overlayScreen.SetActive(true);
			
			overlaySR.DOColor(new Color(1, 1, 1, 1), 2); 
			
			time += Time.deltaTime; 
			if(time >= timer)
			{
				SceneManager.LoadScene("Immigration1");
			}
		}

		if (MTM.EscapeCollision)
		{
			ExitingLevel = true; 
			playerRB.isKinematic = true;
			time += Time.deltaTime; 
			overlayScreen.SetActive(true);

			
			if(time >= timer)
			{
				SceneManager.LoadScene("NewEscape");
			}

		}
	}

	void CameraSaturationValue()
	{
		Camera.main.backgroundColor = Color.HSVToRGB(m_Hue, m_Saturation, m_Value);


	}
}
