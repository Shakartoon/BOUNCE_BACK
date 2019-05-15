using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleSceneManager : MonoBehaviour
{

	public GameObject diamond, textToLoad;
	private float time;
	public float timeToEndGame; 

	public bool ExitScene;
	private bool sceneChanged;
	public bool title2;
	private AsyncOperation asyncLoad;
	
	void Start () {
		
		textToLoad.SetActive(false);
		//asyncLoad = SceneManager.LoadSceneAsync(1);
		//asyncLoad.allowSceneActivation = false;

	}

	IEnumerator WaitBeforeLoad()
	{
		yield return new WaitForSeconds(timeToEndGame);
		//asyncLoad.allowSceneActivation = true;
		NewLevelManagement.lvlManagement.LoadNextLevel();
	} 

	void Update () {
				
		if(diamond.GetComponent<SpriteRenderer>().color == Color.black)
		{
			textToLoad.SetActive(true);
			sceneChanged = true;
			StartCoroutine(WaitBeforeLoad()); 
						
			if(title2)
			{
				StartCoroutine(WaitBeforeLoad()); 
				Application.Quit();
			}

		}		

	}
}
