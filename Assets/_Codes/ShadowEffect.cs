using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShadowEffect : MonoBehaviour
{


	public GameObject player;
	public GameObject prefab;
	public int numberofBalls; 
	public List<GameObject> balls = new List<GameObject>(); 
	private List<Vector3> positions = new List<Vector3>();
	
	void Start () {

		for (int i = 0; i < numberofBalls; i++)
		{
			balls.Add(Instantiate(prefab));
			SpriteRenderer ballSpriteRenderer =  balls[balls.Count - 1].GetComponent<SpriteRenderer>();  // Getting index of last element in it 
			//print((float)(numberofBalls - i) / (numberofBalls + 1));
			//ballSpriteRenderer.color = new Color(ballSpriteRenderer.color.r, ballSpriteRenderer.color.g, ballSpriteRenderer.color.b, (float)(numberofBalls - i) / (numberofBalls + 1)); // alpha value calculated as i value  
			positions.Add(player.transform.position); 
		}
				
	}
	
	// Update is called once per frame
	void Update ()
	{
	//Iterate through the list again 

		for (int i = 0; i < numberofBalls; i++)
		{
			balls[i].transform.position = positions[i]; //assigning the positions to each ball 
		}

		positions.Insert(0, player.transform.position); //where it starts again 
		positions.RemoveAt(numberofBalls);
	}
}
