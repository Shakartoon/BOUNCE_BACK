using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

	
public class inputMGMT : MonoBehaviour {

	private bool isPaused; 
	private InstantiateBeatBall InstantiateBeatBallScript; 

	// Use this for initialization
	void Start ()
	{

		Screen.SetResolution(1600, 900, true); 

	}
	
	// Update is called once per frame
	void Update() { 
		if (Input.GetKeyDown("a")) {
			SceneManager.LoadScene("NewRug"); 
			Debug.Log ("OK"); 
		} 

		if (Input.GetKeyDown("b")) {
			SceneManager.LoadScene("Microphone1"); 
			Debug.Log ("OK"); 
		}


		if (Input.GetKeyDown("c"))
		{
			SceneManager.LoadScene("Microphone4"); 

		}

		if (Input.GetKeyDown("d")) {
			SceneManager.LoadScene("Microphone8"); 
			Debug.Log ("OK"); 
		}
		
		
		
		if (Input.GetKeyDown("e")) {
			SceneManager.LoadScene("FlickingBeatLoop"); 
			Debug.Log ("OK"); 
		}
	
		
		if (Input.GetKeyDown("f")) {
			SceneManager.LoadScene("BallTrail2"); 
			Debug.Log ("OK"); 
		}


		if (Input.GetKeyDown("r"))
		{
			
			SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex ) ;			
		}

		if (Input.GetKeyDown("v") && !isPaused) {
			print ("paused"); 
			Time.timeScale = 0.0f;
			isPaused = true;

		}

		else if(Input.GetKeyDown("v") && isPaused)
		{
			print("Unpaused");
			Time.timeScale = 1.0f;
			isPaused = false;  
		} 

		//why the fuck isn't this working 
		if (Input.GetKeyDown ("x")) {
			Destroy (InstantiateBeatBallScript.beatballClone); 
		}
	}
}
