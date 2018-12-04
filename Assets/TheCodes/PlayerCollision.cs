using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public bool colorChangeCollision; 

	public Material firstMaterial; 

	public GameObject cy3; 
	private Material m; 

	public GameObject hh; 
	public Vector3 defPos;
	Rigidbody2D rb;

	public TrailRenderer tr; 

	public GameObject happyAnim; 


	void Start () {
		defPos = transform.position;
		rb = GetComponent<Rigidbody2D> ();
		tr = GetComponent<TrailRenderer> ();
	}
	void Update(){
		
		if (transform.position.y < -8) {
			rb.velocity = Vector3.zero;
			//this initially made it start wherever it fell from 
			//transform.position = new Vector3(transform.position.x, 5.723693f);
			transform.position = defPos;
			tr.enabled = false; 

			StartCoroutine (trailRender ()); 

		}

		if (transform.position.y > 8) {
			rb.velocity = Vector3.zero;
			transform.position = defPos;

		}

	
	}

	public IEnumerator trailRender () {

		yield return new WaitForSeconds (0.8f); 
		tr.enabled = true; 
		yield return null; 

	}


	void OnCollisionEnter2D (Collision2D col) {
//		Debug.Log ("Collision Detected.");

		transform.GetChild (1).GetComponent<ParticleSystem> ().Play() ;
	

		foreach (ContactPoint2D contact in col.contacts)
		{
			Debug.DrawRay(contact.point, contact.normal, Color.black);
		}


		if (col.relativeVelocity.magnitude > 2) { 	

			Debug.Log ("Magnitude is more than 2"); 

		} 


		if (col.collider.tag == "hh") {

			Services.audioManager.Play ("hh"); 
			GameObject.FindGameObjectsWithTag ("hh"); 
			hh.GetComponent<Renderer>().material.color = Color.yellow;  
		} 

		else if (col.collider.tag == "hh"){
			
			GameObject.FindGameObjectsWithTag ("hh"); 
			hh.GetComponent<Renderer>().material.color = Color.black;  
		}

		if (col.collider.tag == "a") {


			Services.audioManager.Play ("A"); 
		} 


		if (col.collider.tag == "pink_rect") {
		
			Debug.Log ("COLLIDED!"); 
			Services.audioManager.Play ("drumloop1"); 
			 
		} 


		if (col.collider.tag == "hh") {

			Services.audioManager.Play ("hh"); 

		} 


		if (col.collider.tag == "lavendar_rect") {

			Services.audioManager.Play ("icecreamsound"); 

		} 
	
		if (col.collider.tag == "cy1") {

			Services.audioManager.Play ("synth1"); 

		} 

		if (col.collider.tag == "cy2") {

			Services.audioManager.Play ("synth2"); 

		} 

		if (col.collider.tag == "cy3") {

			Services.audioManager.Play ("synth3"); 
		    
//			cy3 = GameObject.FindGameObjectsWithTag ("cy3"); 
//			cy3.GetComponent<Renderer> ().material; //.SetColor("_Color", Color.red);
//			GameObject.FindGameObjectsWithTag ("cy3").Material.color = Color.yellow;


		} 

		if (col.collider.tag == "cy4") {

			Services.audioManager.Play ("synth4"); 

		} 

		if (col.collider.tag == "cdg1") {

			Services.audioManager.Play ("humming"); 

		} 

		if (col.collider.tag == "cdg2") {

			Services.audioManager.Play ("singing"); 

		} 

		if (col.collider.tag == "cdg3") {

			Services.audioManager.Play ("goodboy"); 

		} 

		if (col.collider.tag == "cdg4") {

			Services.audioManager.Play ("cutesound"); 

		} 

		if (col.collider.tag == "cg1") {

			Services.audioManager.Play ("secrets"); 

		}
        if (col.collider.tag == "Metronome")
        {

            Services.audioManager.Play("Metronome");

        }
        if (col.collider.tag == "Rhodes")
        {

            Services.audioManager.Play("Rhodes");

        }
        if (col.collider.tag == "Snare")
        {

            Services.audioManager.Play("High Hat");


        }

        if (col.collider.tag == "Highhat")
        {

            Services.audioManager.Play("Snare Drum");
			colorChangeCollision = true; 

        }
        if (col.collider.tag == "Thoughts")
        {

            Services.audioManager.Play("Thoughts");

        }
        if (col.collider.tag == "Crickets")
        {

            Services.audioManager.Play("Crickets");

        }
        if (col.collider.tag == "Hustling")
        {

            Services.audioManager.Play("Hustling");

        }
        if (col.collider.tag == "Armenian")
        {

            Services.audioManager.Play("Armenian");

        }
        if (col.collider.tag == "Cinematic")
        {

            Services.audioManager.Play("Cinematic");

        }
    }


//	IEnumerator stopSparkles()
//	{
//		//yield return new WaitForSeconds (.4f); 
//
//		sparkle.GetComponent<ParticleSystem> ().enableEmission = false; 
//
//	}


}
