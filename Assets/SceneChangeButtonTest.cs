using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SceneChangeButtonTest : MonoBehaviour
{

	void Start () {
		
	}
	
	void Update () {
		
		if (Input.GetMouseButtonDown(0))
		{
			Debug.Log("Pressed primary button.");
			SceneManager.LoadScene("Hub World");
		}		
	}
}
 