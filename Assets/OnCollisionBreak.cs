using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionBreak : MonoBehaviour
{

	public GameObject squares, middleSquare;

	void Start()
	{
		
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

			Destroy(gameObject);
			Destroy(squares, 0.5f);

			
		//middleSquare.transform.Rotate(0, 0, 90 * 20);
			middleSquare.transform.Rotate(0, 0, 2 * Time.deltaTime * 30);

			
			
		}
	}

}
