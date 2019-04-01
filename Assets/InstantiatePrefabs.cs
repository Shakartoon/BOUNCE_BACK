using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefabs : MonoBehaviour
{

	public Transform pointPrefab; 
	Vector3 position; 

	
    void Awake()
    {
	    for (int i = 0; i < 50; i++) {

		    Transform point = Instantiate(pointPrefab, new Vector3(-20, 20, 0), Quaternion.Euler(new Vector3(0, 0, 90)));
		    point.localPosition = new Vector3(0.5f, 0, 0) * i;

		    //this positions them diagonally: 
		    //point.localPosition = new Vector3(1, 1, 0) * i;
		    //I Guess this is the distance between the game objects on a row or column rather than the position? 
		    //This changes the scale. Don't care about this right now. 
		    //point.localScale = Vector3.one / 5f;




	    }
	   

    } 

	void Start () {
		
	}
	
	void Update () {
		
	}
}
