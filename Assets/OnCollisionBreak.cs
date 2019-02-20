using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionBreak : MonoBehaviour
{
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
			Destroy(gameObject); 
		}
	}

}
