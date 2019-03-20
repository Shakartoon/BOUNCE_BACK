using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleEffect : MonoBehaviour
{

	[SerializeField] float expandTime;
	[SerializeField] private GameObject loadMe;
	private GameObject instantedThing;
	private bool isDestroyed;
	private bool instantied;



	void Start()
	{

	}

	void InstantiateMe()
	{
		
		Instantiate(loadMe, Vector3.zero, transform.rotation);

		
	}
	
	

	void Update()
	{

		float scale = 1f;
		//transform.localScale = new Vector3(scale, scale, 0) * Time.time * expandTime;


		if (instantied == false)
		{
			InstantiateMe(); 
			instantied = true;
		}

	}
} 


/*
 
 
if (loadMe != null)
{
	Instantiate(loadMe, Vector3.zero, transform.rotation);

}

else
{
 
	 if (Instantiated)
{
	Instantiate(loadMe, Vector3.zero, transform.rotation);
	Instantiated = false;
}

if (instantedThing != null)
{
	return; 
}


//loadMe.transform.localScale = new Vector3(scale, scale, 0f);
//instantedThing.transform.localScale = new Vector3(scale, scale, 0) * Time.time * expandTime;

if (transform.localScale.x > 11f)
{
	Destroy(gameObject);

	if (isDestroyed)
	{
		loadMe.transform.localScale = new Vector3(scale, scale, -1f);
		instantedThing = Instantiate(loadMe, transform.position, transform.rotation);
		instantedThing.transform.localScale = new Vector3(scale, scale, 0) * Time.time * expandTime;

	}
	
	if (instantedThing != null)
	{
	
	}

} */ 

