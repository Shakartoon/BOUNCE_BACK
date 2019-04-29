using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using DG.Tweening; 

public class LevelManager_RigFringes : MonoBehaviour
{
	public GameObject obj; 
	private float timer = 5f;
	private float time; 
	
	void Start () {
		
	}
	
	void Update ()
	{

		time += Time.deltaTime;
		if (time >= 5f)
		{
			obj.transform.DOScale(new Vector3(90f, 100f), 5f);
			//obj.transform.localScale += new Vector3(0.1f, 0.1f, 0) * Time.time;
		}

	}
}
