using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackground : MonoBehaviour
{

	public Transform[] things;
	private SpriteRenderer[] sprites; 
	public float speed; 
	
	void Start ()
	{

		sprites = new SpriteRenderer[things.Length];
		
		for (int i = 0; i < sprites.Length; i++)
		{
			sprites[i] = things[i].GetComponent<SpriteRenderer>(); 
		}

		for (int i = 1; i < things.Length; i++)
		{
			things[i].position = things[MyMod(i-1,things.Length)].position + Vector3.right * sprites[i].bounds.size.x ; 

		}
	}
	
	// Update is called once per frame
	void LateUpdate () {

		for (int i = 0; i < things.Length; i++)
		{

			if (Camera.main.WorldToViewportPoint(sprites[i].bounds.max).x < 0)  
			{
				//this means we're off screen 
				Debug.Log(i + " " + (i + (things.Length-1)));
				things[i].position = things[MyMod(i + (things.Length-1),things.Length)].position + Vector3.right * sprites[i].bounds.size.x ; 
			} 

		}
		
		
		
	}

	int MyMod(int a, int b)
	{
		if (b <= 0)
		{
			Debug.LogError("MOD IS BEING PASSED 0 OR A NEGATIVE DONT DO THAT! ");
			return 0;
		}
			
		if (a < 0)
		{
			while (a < 0)
				a += b;
			return a;
		}

		return a % b;

	}
}

