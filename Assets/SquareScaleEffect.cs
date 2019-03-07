using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScaleEffect : MonoBehaviour
{

	public GameObject objectToLoad;
	public float ScaleUntilLoad;
	public float rotationAmount; 
	public float scaleAmount;

	public GameObject[] objects;

	public GameObject clones;
	private GameObject InstObj; 

	public Color[] my_colors = new Color[6]; 

	private float timer;
	private SpriteRenderer SR; 
	
	void Start () {
		
		objectToLoad.SetActive(false);
		objects[2].SetActive(false);
		timer += Time.deltaTime;

		SR = clones.GetComponent<SpriteRenderer>(); 

	}

	void Update ()
	{

		transform.localScale += new Vector3 (scaleAmount, scaleAmount, 0);
		transform.Rotate(0, 0, rotationAmount);

		
			if (transform.localScale.x > ScaleUntilLoad)
			{
				/* 
				objectToLoad.SetActive(true);
				objects[2].SetActive(true);
				timer = 0;
				*/ 
				//SR.color = my_colors[Random.Range(0, my_colors.Length)]; 
				//SR.color = Color.black;
				
				
				InstObj = Instantiate(clones, new Vector3(1, 1, 0), Quaternion.identity); 
				//InstObj.transform.localScale += new Vector3 (scaleAmount, scaleAmount, 0);


			}
		
		for (int i = 0; i < objects.Length; i++)
		{
		} 

	}
}
