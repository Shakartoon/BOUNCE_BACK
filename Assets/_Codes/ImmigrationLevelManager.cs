using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImmigrationLevelManager : MonoBehaviour {

    public GameObject player;
	private Rigidbody2D playerRigidBody;

	public float timer = 1;
	private float time;

	public bool PlayerIsOnTheRight;

	public bool immigration1; 
	public bool immigration2;
	
	void Start ()
	{
		playerRigidBody = player.GetComponent<Rigidbody2D>(); 		
		playerRigidBody.isKinematic = true;

		//playerSpriteRenderer.color = new Color (1, 0, 0, 0); 
	}
	
	void Update ()
	{
			
		time += Time.deltaTime;
		if (time >= timer)
		{
			playerRigidBody.isKinematic = false; 
		}

		
		if (time >= 10)
		{
			NewLevelManagement.lvlManagement.isConditionReached = true;
		}

	}
}
