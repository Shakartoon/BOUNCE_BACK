using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeButtonTest : MonoBehaviour
{
	public float timer; 
	private float time;
	private SpriteRenderer mySR;
	private PolygonCollider2D collider; 

	void Start()
	{
		collider = GetComponent<PolygonCollider2D>(); 
		mySR = GetComponent<SpriteRenderer>();

		collider.enabled = false; 
		mySR.enabled = false; 

	}

	void Update()
	{
		time += Time.deltaTime;
		if (time >= timer)
		{
			collider.enabled = true; 
			mySR.enabled = true; 			
			//time -= Time.deltaTime;
		}
	}

	void OnMouseDown()
	{
		Debug.Log("Literally"); 
		//SceneTracker.me.TimesEnteredHubWorld++; 
		SceneManager.LoadScene("Hub World");

	}

} 
	
