using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSceneManager : MonoBehaviour
{

	public GameObject diamond, textToLoad;
	private float time;
	public float timeToEndGame; 

	public bool ExitScene;
	private bool sceneChanged;
	public bool title2; 
	
	void Start () {
		
		textToLoad.SetActive(false);
		
	}

	IEnumerator WaitBeforeLoad()
	{
		yield return new WaitForSeconds(timeToEndGame); 
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
