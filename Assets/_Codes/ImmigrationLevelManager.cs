using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening; 

public class ImmigrationLevelManager : MonoBehaviour {

    public GameObject player, flock1, sideBalls, hex, borderbugs, levelChanger;
	private Rigidbody2D playerRigidBody;
	
	public float timer = 1;
	public float TimeToShowTheLevelChanger; 
	private float time;
	public float TimeToChangeLevel; 
	public bool PlayerIsOnTheRight;

	public bool immigration1; 
	public bool immigration2;

	public BallMovementScript ballScript;
	public OnCollisionPlaySound SMOscript;
	public CameraPlayerFollow camScript;

	public Camera myCamera; 
	
	void Start ()
	{
		playerRigidBody = player.GetComponent<Rigidbody2D>(); 		
		playerRigidBody.isKinematic = true;
		
		flock1.SetActive(false);
		sideBalls.SetActive(false);
		hex.SetActive(false);
		borderbugs.SetActive(false);
		if (levelChanger != null)
			levelChanger.SetActive(false);

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

		if (time >= TimeToShowTheLevelChanger)
		{
			if (levelChanger != null)
				levelChanger.SetActive(true);
		}
		
		if (time >= TimeToChangeLevel) // || ballScript.levelChangeCollisionHappened)
		{
			NewLevelManagement.lvlManagement.LoadNextLevel();
		}

		if (immigration2)
		{
			if (SMOscript.collidedWithBall || ballScript.immObjCollision || time >= TimeToChangeLevel)
			{
				//DOTween.Shake(camScript.zOffset); 
				//camScript.zOffset.transform.DOTween.Shake(2, 4, 4, 3f);
				NewLevelManagement.lvlManagement.LoadNextLevel();
				Camera.main.transform.DOShakePosition(2, new Vector3(0, 0, 10), 1, 1); 
				//NewLevelManagement.lvlManagement.LoadNextLevel();

				//myCamera.transform.DOShakePosition(2, 4, 4, 3f);
				//camScript.smoothSpeed = camScript.smoothSpeed =-5; 
				//camScript.target.position 
			}
			
		}

	}
}
