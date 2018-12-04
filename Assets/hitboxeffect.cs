using System.Collections;
using System.Collections.Generic;
using Pixelplacement.TweenSystem;
using UnityEngine;

public class hitboxeffect : MonoBehaviour
{

	public GameObject objToRotate;
	private AudioSource AS; 

	public float _xRotation;
	public float _timeToRotate1; 
	
	void Start ()
	{
		AS = objToRotate.GetComponent<AudioSource>(); 
	}

	void Update()
	{
	
	}
	


	IEnumerator objectRotation()
	{
		iTween.RotateTo(objToRotate, new Vector3(0, 0, _xRotation), _timeToRotate1);
		iTween.ColorFrom(objToRotate, Color.magenta, 2f); 

		yield return new WaitForSeconds(0.1f); 
		iTween.RotateTo(objToRotate, new Vector3(0, 0, 0), 1f);

	}
	
	
	
	
	void OnCollisionEnter2D (Collision2D collision) {

		if (collision.gameObject.CompareTag ("Ball"))
		{
			StartCoroutine(objectRotation());
			//iTween.AudioFrom(objToRotate, 2, 5, 4); 
			//iTween.MoveTo(objToRotate, new Vector3 (Random.Range(-7, 7), Random.Range(0, 7), 0), 5f); //this code makes object randomly move on collision so cool 
				
			Debug.Log("PLEASE, FUCK");

		}
		
		
	}
}
