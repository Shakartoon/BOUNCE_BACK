using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class Immigration2LevelManager : MonoBehaviour
{

	public moveAcrossScreen camMove;
	public float timer = 5f;
	public float time;  

	public GameObject[] things; 
	private SpriteRenderer[] sprites; 
	
	void Start ()
	{

		camMove.enabled = false; 
		sprites = new SpriteRenderer[things.Length];
		
		for (int i = 0; i < sprites.Length; i++)
		{
			sprites[i] = things[i].GetComponent<SpriteRenderer>(); 
		}

	}
	
	void Update ()
	{

		time += Time.deltaTime;
		if (time >= timer)
		{
			camMove.enabled = true; 
			
			for (int i = 0; i < sprites.Length; i++)
			{
				sprites[i].DOColor(new Color(1, 1, 1, 0), 4f); 
			}
		}

	}
}
