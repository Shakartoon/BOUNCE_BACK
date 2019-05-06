using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class OnCollisionBreak : MonoBehaviour
{

	public GameObject squares, middleEffect, player, moonball;
	private Component[] sprites;
	private float decrementValue;
	private float alphaValue = 1;
	public bool firstEscape; 

	void Start()
	{
		sprites = GetComponentsInChildren<SpriteRenderer>();
		middleEffect.SetActive(false);
	}
	
	void Update()
	{
		bool allChildrenAreBlack = true;
		foreach (Transform child in transform)
		{
			if (child.GetComponent<SpriteRenderer>().color != Color.black)
			{
				allChildrenAreBlack = false;
				//print(child.GetComponent<SpriteRenderer>().color);
				break;
			}
		}

		if (allChildrenAreBlack)
		{
			//decrementValue -= Time.deltaTime;  
			for (int i = 0; i < sprites.Length; i++)
			{	alphaValue -= decrementValue;
				Color newColor = new Color(0, 0, 0, alphaValue);
				sprites[i].GetComponent<SpriteRenderer>().color = newColor; 
			}
			
			Destroy(gameObject, 1);
			Destroy(squares, 0.5f);
			middleEffect.SetActive(true);
			middleEffect.transform.DOScale(new Vector3(6, 6, 0), 3f); 
			if (middleEffect.transform.localScale.x >= 6)
			{

				Destroy(middleEffect); 
			}

			if (firstEscape)
			{
				player.transform.DOScale(new Vector3(0.12f, 0.12f, transform.localScale.z), 2f); 
				moonball.transform.DOScale(new Vector3(0.12f, 0.12f, transform.localScale.z), 2.5f); 
			}


			//middleSquare.transform.Rotate(0, 0, 90 * 20);
			//middleSquare.transform.Rotate(0, 0, 2 * Time.deltaTime * 30);



		}
	}

}
