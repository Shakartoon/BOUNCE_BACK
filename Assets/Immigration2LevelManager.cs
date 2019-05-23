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

	public GameObject rug1, rug2;
	private SpriteRenderer rug1Sprite, rug2Sprite;  

	
	void Start ()
	{

		camMove.enabled = false; 
		sprites = new SpriteRenderer[things.Length];
	
		for (int i = 0; i < sprites.Length; i++)
		{
			sprites[i] = things[i].GetComponent<SpriteRenderer>(); 
		}
		
		rug1Sprite = rug1.GetComponent<SpriteRenderer>(); 
		rug2Sprite = rug2.GetComponent<SpriteRenderer>(); 


	}
	
	void Update ()
	{

		time += Time.deltaTime;
		if (time >= timer)
		{			
			for (int i = 0; i < sprites.Length; i++)
			{
				sprites[i].DOColor(new Color(1, 1, 1, 0), 5f);
			}
		}

		if (time >= timer + 1.3f)
		{
			rug1Sprite.DOColor(new Color(55f / 255f, 55f / 255f, 55f / 255f, 1), 2f); 
			rug2Sprite.DOColor(new Color(70f / 255f, 54f / 255f, 54f / 255f, 182f / 255f), 2f); 
		}

		if (time >= timer + 1.5f)
		{
			camMove.enabled = true;
		}

	}
}
