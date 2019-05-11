using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RugFringeLevelManager : MonoBehaviour
{

	public GameObject tileObj1, tileObj2;
	public GameObject line1, line2, line3, line4, line5; 
	public float TimeToMoveTitleObjs, timeToChangeLevel;
	private float time; 
	
	void Start ()
	{
		tileObj1.GetComponent<moveAcrossScreen>().enabled = false; 
		tileObj2.GetComponent<moveAcrossScreen>().enabled = false; 
	}
	
	// Update is called once per frame
	void Update ()
	{

		time += Time.deltaTime;
		if (time >= TimeToMoveTitleObjs)
		{
			tileObj1.GetComponent<moveAcrossScreen>().enabled = true; 
			tileObj2.GetComponent<moveAcrossScreen>().enabled = true; 
		}

		//if (time >= 5)
		
		if(line1.GetComponentInChildren<SpriteRenderer>().color == Color.black &&line2.GetComponentInChildren<SpriteRenderer>().color == Color.black && line3.GetComponentInChildren<SpriteRenderer>().color == Color.black
		   && line4.GetComponentInChildren<SpriteRenderer>().color == Color.black && line5.GetComponentInChildren<SpriteRenderer>().color == Color.black)
		{
			Debug.Log("YOU DID IT!!");
			NewLevelManagement.lvlManagement.LoadNextLevel();
		}

	}
}
