using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class newSoundMakingObject : MonoBehaviour {

	public GameObject myBall; 
	public AudioClip myClip; 
	public AudioSource myAudioSource;
	public bool myCollision;
	private Vector3 defaultPosition; 
	private Vector3 newPosition;

	public GameObject rotatingCube;
	private instantiateOnDrag _instantiateOnDrag; 

	// Timer- stops when L button is released and immediately start a loop immedialtey a new ball instiate 
//	public instantiateOnDrag instantiateScript; 


	void Start () {
		myAudioSource = GetComponent<AudioSource>(); 
		myAudioSource.clip = myClip; 
		defaultPosition = transform.position; 
		
	}
	
	// Update is called once per frame

	public IEnumerator destroyBall() {

		yield return new WaitForSeconds (1); 
//		Destroy (instantiateScript.ball); 
	
	}

/*
	public IEnumerator wiggleAnimation()
	{
		float speed = 0.1f; //time?
		float delta = 0.5f; //length 
		float y = transform.position.y + Mathf.PingPong(speed * Time.time, delta); 
		Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
		transform.position = pos; 
		yield return new WaitForSeconds(0.06f);
		
		float speed1 = 0.1f; //time?
		float delta1 = -0.1f; //length / position? 
		float y1 = transform.position.y + Mathf.PingPong(speed1 * Time.time, delta1); 
		Vector3 pos1 = new Vector3(transform.position.x, y1, transform.position.z);
		transform.position = pos1; 
		
		yield return new WaitForSeconds(0.01f);
		transform.position = defaultPosition; 
		
		float speed2 = 0.3f; //time?
		float delta2 = 0.5f; //length 
		float y2 = transform.position.y + Mathf.PingPong(speed2 * Time.time, delta2); 
		Vector3 pos2 = new Vector3(transform.position.x, y2, transform.position.z);
		transform.position = pos2; 
		yield return new WaitForSeconds(0.04f);
		
		float speed3 = 0.2f; //time?
		float delta3 = -0.1f; //length / position? 
		float y3 = transform.position.y + Mathf.PingPong(speed3 * Time.time, delta3); 
		Vector3 pos3 = new Vector3(transform.position.x, y3, transform.position.z);
		transform.position = pos3; 
		
		yield return new WaitForSeconds(0.01f);
		transform.position = defaultPosition; 

	}
*/
	
	
	void OnCollisionEnter2D(Collision2D collision)
		{

			if (collision.gameObject.CompareTag ("Ball")) {
		
			myAudioSource.Play (); 
			myCollision = true;

			//StartCoroutine(wiggleAnimation());
			//StartCoroutine(ballScale());

			
			//iTween.RotateBy(gameObject, iTween.Hash("y", .25, "easeType", "easeInOutBack", "loopType", "pingPong", "delay", .01));
			//iTween.RotateBy(gameObject, new Vector3(0, 0, 20), 1f);

			//iTween.RotateBy(gameObject, iTween.Hash("x", .25, "easeType", "easeInOutBack", "loopType", "pingPong", "delay", .1));
			
				//else make iTween stop 
				//	StartCoroutine (destroyBall ()); 
				//	myAudioSource.PlayOneShot (myClip); //, Random.Range(0.25f, 0.75f)); 
				//	myAudioSource.pitch = (Random.Range (1, 3)); 
			}
	}
		
} 
