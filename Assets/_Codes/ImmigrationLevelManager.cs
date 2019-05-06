using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmigrationLevelManager : MonoBehaviour {

    public GameObject player;
	private Rigidbody2D playerRigidBody;
	private SpriteRenderer playerSpriteRenderer; 

	public float timer = 1;
	private float time;

	public bool PlayerIsOnTheRight; 

	void Start ()
	{
		playerRigidBody = player.GetComponent<Rigidbody2D>(); 
		playerSpriteRenderer = player.GetComponent<SpriteRenderer>();
		
		playerRigidBody.isKinematic = true;
		//playerSpriteRenderer.color = new Color (1, 0, 0, 0); 
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Any way to make this more efficient? 
		time += Time.deltaTime;
		if (time >= timer)
		{
			playerRigidBody.isKinematic = false; 
			//playerSpriteRenderer.color = new Color (1, 1, 1, 1); 
		}
		
		if (player.transform.position.x >= 24f)
		{
			PlayerIsOnTheRight = true; 
		}

		if (SceneTracker.me.TimesPlayedImmigration == 0)
		{
			Debug.Log("FirstTime");
		}
		
		
		//Start by placing tiles 
		//if collision count is a certain number 
		// make snake move more 
		// move camera 
		// move objects to camera 

	}
}
