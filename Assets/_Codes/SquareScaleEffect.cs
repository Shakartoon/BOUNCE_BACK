using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class SquareScaleEffect : MonoBehaviour
{

	public float xVal; 
	public GameObject objectToLoad;
	private GameObject currentObject; 
	public float ScaleUntilLoad;
	public float scaleAmountX;
	public float scaleAmountY;
	public float rotationAmount;
	private SpriteRenderer sr; 

	public Color[] my_colors = new Color[6];

	//private SpriteRenderer SR; 
	
	void Start () {
		
		LoadNewObject(); 
		SpriteRenderer sr = GetComponent<SpriteRenderer>();

	}

	void Update ()
	{

		if (currentObject == null)
		{
			return; 

		}
		
		currentObject.transform.localScale += new Vector3 (scaleAmountX, scaleAmountY, 0);
		currentObject.transform.Rotate(0, 0, rotationAmount);


		//float width = currentObject.GetComponent<SpriteRenderer>().bounds.size.x; 

		if (currentObject.transform.localScale.x > Screen.width / xVal) 
		{
			LoadNewObject();
		}
				
		if (currentObject != null)
		{

			Destroy(currentObject, 3);
			
		}
		

	}

	void LoadNewObject()
	{
		
		currentObject = Instantiate(objectToLoad, new Vector3(1, 1, 0), Quaternion.identity);
		currentObject.GetComponent<SpriteRenderer>().color = my_colors[Random.Range(0, my_colors.Length)];
		
	}
	
	
}
