using System.Collections;
using System.Collections.Generic;
using EZCameraShake; 
using UnityEngine;

public class triangleTrigger : MonoBehaviour {

	public GameObject mainBallPlayer; 
	public GameObject BGtiangle; 
	public clockwiserotation clockwiseRotation; 

	public Rigidbody2D mainBallPlayerRB; 
	public Transform newPosition; 
	public Vector3 ball1Pos; 
	static bool filled;

	public AudioSource source;
	public AudioClip mySound; 
	public clockwiserotation myFriendWhoImGonnaCheck;

	public ParticleSystem PS; 
	//public CameraShake cameraShake; 

	void Start () {
		
		source = GetComponent<AudioSource>();
		//PS.GetComponent<ParticleSystem>().enableEmission = false;
		PS.GetComponent<ParticleSystem>();


		// on the stars- on trigger enter / make the ball kinematic and set the position / center point the position of the star then instantiate a new ball and set main ball and main ball RB about the arrow- write down defailt position 
		/*mainBallPlayerRB = mainBallPlayer.GetComponent<Rigidbody2D>(); 
		mainBallPlayerRB.isKinematic = true; 
		mainBallPlayerRB.velocity = Vector2.zero;*/
	
	}
	
	// Update is called once per frame
	IEnumerator DestroyInASec(GameObject obj){
		yield return new WaitForSeconds (01f);
		Destroy (obj);
		filled = false;
	}
	void OnTriggerEnter2D (Collider2D col) {

		if (!filled && col.gameObject.tag == "Ball") {
			myFriendWhoImGonnaCheck.wasHit = true;
			filled = true;

		//	PS.enableEmission = true;
			PS.Play (); 

			Debug.Log ("this Totes Worked"); 
			col.transform.position = ball1Pos; //new Vector3(0.0f, 1.5f, 0.0f); 
			col.GetComponent<Rigidbody2D>().isKinematic = true; 
			col.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			StartCoroutine (DestroyInASec (col.gameObject));

			AudioSource.PlayClipAtPoint(mySound, transform.position); 
		
			CameraShaker.Instance.ShakeOnce (1f, 2f, .2f, 2f); 
			// StartCoroutine(cameraShake.Shake(0.05f, 0.05f));  
		} 


	}
}
