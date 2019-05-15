using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewLevelManagement : MonoBehaviour
{
	private float timeToEndGame; 
	public bool isConditionReached = false;
	public static NewLevelManagement lvlManagement; 
	private AsyncOperation asyncLoad;
	public AudioSource transitionSource;
	private bool midChange;
	void Start ()
	{
		if (lvlManagement == null) {
			DontDestroyOnLoad (gameObject);
			lvlManagement = this;
		} else if (lvlManagement != this) {
			Destroy (gameObject);
			return;
		}
		asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
		SceneManager.sceneLoaded += LevelWasLoaded; //
		
		asyncLoad.allowSceneActivation = false;
		transitionSource = ((GameObject) Instantiate(Resources.Load("TransitionSource"))).GetComponent<AudioSource>();
		transitionSource.transform.parent = transform;

	}

	void Update () {
		
	}


	public void LevelWasLoaded(Scene scene, LoadSceneMode mode)
	{
		asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
		asyncLoad.allowSceneActivation = false;
		transitionSource.Play();
	}

	IEnumerator LoadNextCo()
	{
		midChange = true;
		while (true)
		{
			yield return null;
			AudioListener.volume -= Time.deltaTime * 6f;
			if (AudioListener.volume <= 0)
				break;
		}

		AudioListener.volume = 1;
		asyncLoad.allowSceneActivation = true;
		yield return null;
		midChange = false;
	}
	public void LoadNextLevel()
	{
		if (!midChange)
		{
			StartCoroutine(LoadNextCo());
		}
		//StartCoroutine(WaitBeforeLoad()); 
		//int indexOfSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
		//SceneManager.LoadScene(indexOfSceneToLoad);

	}

	public void LoadLevel(string levelName)
	{
		SceneManager.LoadScene(levelName);
		Debug.Log((SceneManager.GetActiveScene().buildIndex+1f) + "is the current active scene");
	}

}
		
	/*
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
	}*/ 


