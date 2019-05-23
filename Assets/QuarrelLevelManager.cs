using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class QuarrelLevelManager : MonoBehaviour {

	public GameObject player, pink, blue, instantiateCircles, wholeShit;
	private float time, timeToEnableRB = 2f;
	public float addedTime, timeToEndLevel; 
	
	private AsyncOperation asyncLoad;

	
	void Start ()
	{

		player.GetComponent<Rigidbody2D>().isKinematic = true; 
		pink.SetActive(false);
		blue.SetActive(false);
		instantiateCircles.SetActive(false);
	}

	IEnumerator WaitBeforeLoad()
	{
		yield return new WaitForSeconds(4);
		//asyncLoad.allowSceneActivation = true;
		NewLevelManagement.lvlManagement.LoadNextLevel();
	} 
	void Update ()
	{
		time += Time.deltaTime; 
		if (time >= timeToEnableRB)
		{
			player.GetComponent<Rigidbody2D>().isKinematic = false; 

		}

		if (time >= timeToEnableRB + addedTime)
		{
			pink.SetActive(true);
			blue.SetActive(true);
		if (time >= timeToEnableRB + addedTime + 4)
		{
			instantiateCircles.SetActive(true);
		}
		}

		if (time >= timeToEndLevel)
		{
			wholeShit.transform.DOScale(new Vector3(0, 0, 0), 4); 
			StartCoroutine(WaitBeforeLoad()); 

		}
	}
}
