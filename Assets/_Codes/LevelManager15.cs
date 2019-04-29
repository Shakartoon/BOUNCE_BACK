using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class LevelManager15 : MonoBehaviour {
	
	float m_FieldOfView = 10;
	private bool Collided;
	public Camera mainCamera;
	public CameraPlayerFollow fpScript;
	public GameObject objectZoomIn; 
	
	void Start ()
	{

		fpScript.enabled = true; 
	}
	
	void Update () {

		if (Collided)
		{
			fpScript.enabled = false;
			Camera.main.transform.position = new Vector3(149f, 100f, -23.8f);
			Camera.main.fieldOfView = m_FieldOfView;
			SceneManager.LoadScene("CameraLevel 2"); 
			/* 
			float x = Vector3.Distance(Vector3.zero, Camera.main.transform.position);
			float y = height / 2f;
			float requiredFOV = Mathf.Atan(y / x) * Mathf.Rad2Deg;
			Camera.main.fieldOfView = requiredFOV * 2f;
			*/


		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.CompareTag("Ball"))
		{
			Collided = true; 

		}
	}
}
