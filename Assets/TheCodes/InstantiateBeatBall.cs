using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateBeatBall : MonoBehaviour {

	public GameObject beatBall; 
	public Vector2 newPosition; 
	//public Vector3 previousPosition; 
	//private Transform myBall; 

	public float range;
	public GameObject beatballClone;

	public GameObject[] beatBallPrefab; 
	public GameObject[] beatBallArray;
	public Vector2[] newPositions; 
	
	//FIND CURRENT POSITION OF ORIGINAL BEAT BALL AND INSTANTIATE IT THERE, MOVING IT ON THE X POSITION LEFT OR RIGHT


	void Start () {

		//myBall = beatBall.transform; 
		range = Random.Range(0, 7 + 1);
	}

	//Instantiate the BeatBall on button press 

	public void SpawnPrefab()
	{
		
		
	}
	
	
	void OnMouseDown(){
		
		if(Input.GetMouseButtonDown(0))
		{
			Debug.Log("ButtonPressed!");
			beatballClone = Instantiate(beatBall, newPosition, transform.rotation);

		}
	

		newPosition = new Vector2 (1, 1); 
		beatballClone = Instantiate(beatBall, newPosition, transform.rotation);


		beatBallArray = new GameObject[beatBallPrefab.Length]; 
		
		for (int i = 0; i < beatBallPrefab.Length; i++)
         		{
         			newPositions = new Vector2[4];   
         			beatBallArray[i] = Instantiate(beatBallPrefab[i], newPositions[i], transform.rotation);
         	
         		}
		//previousPosition = myBall.transform.position; 
		//	Instantiate (beatBall, new Vector3 (0, 0, 0), Quaternion.identity);
		
		//Instantiate (beatBall, previousPosition, Quaternion.identity); 
		//Instantiate (beatBall, new Vector3(Random.Range (-9, 9), 0, 0), Quaternion.identity); 

	}

}
