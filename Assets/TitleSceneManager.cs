using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneManager : MonoBehaviour
{

	public GameObject diamond, textToLoad;
	private float time;
	private float timer = 5;

	public bool ExitScene;
	private bool sceneChanged; 
	
	void Start () {
		
		textToLoad.SetActive(false);
		
	}
	
	// Update is called once per frame
	void Update () {
				
		if(diamond.GetComponent<SpriteRenderer>().color == Color.black)
		{
			textToLoad.SetActive(true);
			
		//	time += Time.deltaTime; 
		//	if (time >= timer)
		//	{
			NewLevelManagement.lvlManagement.LoadNextLevel();
			sceneChanged = true; 

			//	}		
		}

		if (ExitScene && sceneChanged)
		{
			
			Application.Quit();

		}
	}
}
