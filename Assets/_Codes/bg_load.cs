using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
//using JetBrains.Rider.Unity.Editor; 
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class bg_load : MonoBehaviour
{

	public GameObject bgBall;
	public Vector2 hi; 
	private float additionAmount;

	private Vector3 startPosition;
	private static List<GameObject> createObjects = new List<GameObject>();
	public Object[] subListObjects;
	private static int ballIndex = 1;

	private Vector2 temp; 
	
	// Use this for initialization
	void Start ()
	{
		subListObjects = Resources.LoadAll("bgBall", typeof(GameObject));
		startPosition = transform.position; 
		showPrefabs(ballIndex);

		foreach (GameObject list in subListObjects)
		{
			GameObject bgBall = (GameObject) list;
			createObjects.Add(bgBall); 
		}
	}

	IEnumerator InstantiateObjects()
	{
		//new syntax 
		foreach (GameObject i in createObjects)
		{
			GameObject instance = Instantiate (i, temp, Quaternion.identity); 
			i.transform.localPosition = new Vector3(10, 10, 1);
			yield return new WaitForSeconds(5); 
		}
		
	}

	void showPrefabs(int n)
	{
		temp = new Vector3(1, 1); 
		var x = createObjects.Count;

		if (n > createObjects.Count)
		{

			ballIndex = 1; 
		}

		if (n < 1)

			ballIndex = createObjects.Count; 
	StartCoroutine(InstantiateObjects());

	}


	public void plusPrefabs(int n)
	{
		showPrefabs(ballIndex += n);
	}
	
	
	void Update ()
	{

		plusPrefabs(1);
		showPrefabs(1); 

	}
}
