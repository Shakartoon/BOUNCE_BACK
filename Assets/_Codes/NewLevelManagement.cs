using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewLevelManagement : MonoBehaviour
{
	public bool isConditionReached = false;
	public static NewLevelManagement lvlManagement;
	
	void Start ()
	{
		if (lvlManagement == null) {
			DontDestroyOnLoad (gameObject);
			lvlManagement = this;
		} else if (lvlManagement != this) {
			Destroy (gameObject);
		}

	}

	void Update () {
		
		//Hub World 1
		// Immigration 1 
		// Rug Fringe 1 
		//Hub World 2
		// Immigration 2 
		// Pap i rose 
		//Hub World 3 
		// Escape 
		// Rug Fringe 2 
		// Phone 
		
		if (isConditionReached == true) 
		{
			isConditionReached = false;
			int indexOfSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
			SceneManager.LoadScene(indexOfSceneToLoad);
			
			Debug.Log((SceneManager.GetActiveScene().buildIndex+1f) + "is the current active scene");
		}
		

	}

	public void LoadNextLevel()
	{
		int indexOfSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
		SceneManager.LoadScene(indexOfSceneToLoad);
			
		Debug.Log((SceneManager.GetActiveScene().buildIndex+1f) + "is the current active scene");
		
	}

	public void LoadLevel(string levelName)
	{
		SceneManager.LoadScene(levelName);
		Debug.Log((SceneManager.GetActiveScene().buildIndex+1f) + "is the current active scene");
	}




}
