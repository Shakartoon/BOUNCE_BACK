using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;


public class SceneChanger : MonoBehaviour
{
	public float timer = 0f;
	public float timeToNextScene = 45f;
	
	public GameObject[] _short;
	public GameObject[] _medium; 
	public GameObject[] _long;

	private bool isShort; 
	private bool isMedium; 
	private bool isLong; 


	public float shortSceneTime = Random.Range(5, 10); 
	public float MediumSceneTime = Random.Range(10, 25); 
	public float LongSceneTime = Random.Range(40, 60);  
		
	void Awake()
	{

		DontDestroyOnLoad(transform.gameObject); 

	}
	
	
	void Start ()
	{

		_short = GameObject.FindGameObjectsWithTag("Short"); 
		
		if (_short.Length >= 0)
		{
			isShort = true; 

		}
			
		_medium = GameObject.FindGameObjectsWithTag("Medium"); 
		{ 
			isMedium = true; 

		}
			
		_long = GameObject.FindGameObjectsWithTag("Medium"); 
		{ 
			isLong = true; 

		}

	}


	void Update()
	{

		timer += Time.deltaTime;
		
		if (timer >= timeToNextScene || Input.GetKey(KeyCode.RightArrow))   

		{
			
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
			timer = 0; 

		}
		
		if (Input.GetKey(KeyCode.LeftArrow))   

		{
			
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
			timer = 0; 
		}
		
		
		/* 


		if (isShort = true)
		{
			timeToNextScene = shortSceneTime; 

		}
		
		if (isMedium = true)
		{
			timeToNextScene = shortSceneTime; 

		}
		
		if (isLong = true)
		{
			timeToNextScene = shortSceneTime; 

		}
		
		
		
		/* 
		if (timer >= 3f)
		{

			SceneManager.LoadScene("Microphone11");
			timer = 0;

			if (timer >= 3f && scene.name == "Microphone11")
			{
				SceneManager.LoadScene("Microphone1");
				timer = 0f;

			}


		}
		*/ 

	} 

}
