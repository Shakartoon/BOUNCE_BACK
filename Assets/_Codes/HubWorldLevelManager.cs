using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;


public class HubWorldLevelManager : MonoBehaviour
{

	public Maze_TriggerManager MTM;
	[HideInInspector] public bool ExitingLevel;

	public GameObject player;
	private Rigidbody2D playerRB;

	public GameObject overlayScreen;
	private SpriteRenderer overlaySR;

	private float timer = 2f;
	private float time;

	public GameObject noise;
	public GameObject upperBG;
	public GameObject lowerBG;

	public float m_Hue;
	public float m_Saturation;
	public float m_Value;
	//public CameraShaker cameraShakeScript; ??????? 
	//ShakeOnce

	void Start()
	{
		playerRB = player.GetComponent<Rigidbody2D>();
		overlaySR = overlayScreen.GetComponent<SpriteRenderer>();
		overlayScreen.SetActive(false);
		noise.SetActive(false);

	}

	void CollidedWithLevelChanger()
	{
		playerRB.isKinematic = true;
		ExitingLevel = true; //to access color correction curves script //need one for entering level 
		overlayScreen.SetActive(true);
		overlaySR.DOColor(new Color(1, 1, 1, 1), 2);
	}

	void Update()
	{
		
		//Immigration Level
		if (MTM.ImmigrationCollision)
		{
			Debug.Log("String");
			CollidedWithLevelChanger();
			time += Time.deltaTime;

			if (time >= timer)
			{
				SceneTracker.me.TimesPlayedImmigration++;
				SceneManager.LoadScene("Immigration1");
				
				time = 0;
			}
		}

		//Rug Fringe Level
		if (MTM.FringeCollision)
		{
			CollidedWithLevelChanger();

			if (time >= timer)
			{
				SceneTracker.me.TimesPlayedRugFringe++;
				SceneManager.LoadScene("RugFringe");
				time = 0;
			}
		}

		//Papi-ros Level 
		if (MTM.PapirosCollision)
		{
			CollidedWithLevelChanger();

			if (time >= timer)
			{
				SceneTracker.me.TimesPlayedPapiros++;
				SceneManager.LoadScene("Papiros Poem");
				time = 0;
			}

		}

		//Escape Level 
		if (MTM.EscapeCollision)
		{
			CollidedWithLevelChanger();

			if (time >= timer)
			{
				SceneTracker.me.TimesPlayedEscape++;
				SceneManager.LoadScene("NewEscape");
				time = 0;
			}

		}

		//Goodbye Level 
		if (MTM.TriangleCollision)
		{
			CollidedWithLevelChanger();

			if (time >= timer)
			{
				SceneTracker.me.TimesPlayedTriangle++;
				SceneManager.LoadScene("NewEscape");
				time = 0;
			}

		}

	}
} 

//Papi Rose, Papi Rose 
//Camera.main.backgroundColor = Color.HSVToRGB(m_Hue, m_Saturation, m_Value);

		//CameraSaturationValue(); 
		//SceneTracker.me.TimesPlayedLevel1++;
					
		//Camera.main.transform.position = new Vector3(149f, 100f, -23.8f);
		//Camera.main.fieldOfView = m_FieldOfView;
		//SceneTracker.sceneTracker.lastLevelPlayer = 1;
 
		/* if (SceneTracker.me.TimesPlayedLevel1 > 0)
		{
		}

		/* 
		float x = Vector3.Distance(Vector3.zero, Camera.main.transform.position);
		float y = height / 2f;
		float requiredFOV = Mathf.Atan(y / x) * Mathf.Rad2Deg;
		Camera.main.fieldOfView = requiredFOV * 2f;
		
		
		if (SceneTracker.me.TimesEnteredHubWorld == 1)
		{
		
			noise.SetActive(true);
			Debug.Log("problems");
		} */
		
	/* 
	void CameraSaturationValue()
	{
		Camera.main.backgroundColor = Color.HSVToRGB(m_Hue, m_Saturation, m_Value);


	}*/ 

