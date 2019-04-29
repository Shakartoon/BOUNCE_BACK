using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_button : MonoBehaviour {


	public GameObject exampleCube; 
	public GameObject menuBox; 
	public GameObject xButton; 
    public bool buttonPressed = false;

    void Start() {

    }

    // Update is called once per frame
    void Update() {
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Licked");
			menuBox.SetActive(true);
            buttonPressed = true;
        }

		if (Input.GetMouseButtonDown(1)) {

			menuBox.SetActive(false);

		} 
			
    }

}
