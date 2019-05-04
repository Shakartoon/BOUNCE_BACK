using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class PapirosLevelManager : MonoBehaviour {

	//temporary conditions
	private float timer = 3f; 
	private float time;
	private int CameraMoves;

	public Vector3 position1, position2, position3, position4, position5, position6; 
	
	void Start () {
		
	}
	
	void Update () {

		//move camera in a sequence 

		if (Camera.main.transform.position == position1)
		{
			time += Time.deltaTime;
			if (time > timer)
			{
				
				Camera.main.transform.DOMove(position2, 1);
				time = 0;
			}
		} 
		
		if (Camera.main.transform.position == position2)
		{
			time += Time.deltaTime;
			if (time > timer)
			{
				Camera.main.transform.DOMove(position3, 1);
				time = 0;
			}
		} 
		
		if (Camera.main.transform.position == position3)
		{
			time += Time.deltaTime;
			if (time > timer)
			{
				Camera.main.transform.DOMove(position4, 1);
				time = 0;
			}
		} 
		
		if (Camera.main.transform.position == position4)
		{
			time += Time.deltaTime;
			if (time > timer)
			{
				Camera.main.transform.DOMove(position5, 1);
				time = 0;
			}
		} 
		
		if (Camera.main.transform.position == position5)
		{
			time += Time.deltaTime;
			if (time > timer)
			{
				Camera.main.transform.DOMove(position6, 1);
				time = 0;
			}
		} 
		
	}
}
