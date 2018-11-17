using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class newSoundMakingObject : MonoBehaviour {

	public GameObject myBall; 
	public AudioClip myClip; 
	public AudioSource myAudioSource;
	public bool myCollision; 
//	public instantiateOnDrag instantiateScript; 


	void Start () {
		myAudioSource = GetComponent<AudioSource>(); 
		myAudioSource.clip = myClip; 
	}
	
	// Update is called once per frame

	public IEnumerator destroyBall() {

		yield return new WaitForSeconds (1); 
//		Destroy (instantiateScript.ball); 
	
	} 

	void OnCollisionEnter2D(Collision2D collision)
		{

			if (collision.gameObject.CompareTag ("Ball")) {
		
			myAudioSource.Play (); 
			myCollision = true; 

		//	StartCoroutine (destroyBall ()); 
		//	myAudioSource.PlayOneShot (myClip); //, Random.Range(0.25f, 0.75f)); 
		//	myAudioSource.pitch = (Random.Range (1, 3)); 
		}
	}
		
} 
