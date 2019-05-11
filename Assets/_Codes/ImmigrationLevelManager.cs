using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ImmigrationLevelManager : MonoBehaviour {

    public GameObject player, flock1, sideBalls, hex, borderbugs;
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
		
		flock1.SetActive(false);
		sideBalls.SetActive(false);
		hex.SetActive(false);
		borderbugs.SetActive(false);

		//border.GetComponent<Rotate>().enabled = true;
		//border.GetComponent<Rotate>().rotateBackAndForth = true;

		//borderRotateScript.enabled = true;

		//playerSpriteRenderer.color = new Color (1, 0, 0, 0); 
	}

	private bool turnedOffKinematic = false;
	
	void Update ()
	{
			
		time += Time.deltaTime;
		if (time >= timer && !turnedOffKinematic)
		{
			//time = 0; 
			turnedOffKinematic = true;
			playerRigidBody.isKinematic = false; 
		}

		if (time >= 5f)
		{
			flock1.SetActive(true);
			sideBalls.SetActive(true);
			hex.SetActive(true);
			borderbugs.SetActive(true);			
		}

		
		if (time >= 10)
		{
			time = 0; 
			NewLevelManagement.lvlManagement.LoadNextLevel();
		}

	}
}
