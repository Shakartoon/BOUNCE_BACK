using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatePrefabs : MonoBehaviour
{

	public Transform pointPrefab; 
	Vector3 position;
	public int verticalCount, horizontalCount;
	public float marginX, marginY; 
	
    void Awake()
    {
	    int spawnState = 0;
	    float gapdistanceX = (1 - marginX * 2) / (horizontalCount - 2);
	    float gapdistanceY = (1 - marginY * 2) / (verticalCount - 2);
	    Vector3 spawnPos = new Vector3(marginX - gapdistanceX, 1 - marginY, 10);
	    
	    for (int i = 0; i < (verticalCount + horizontalCount - 2) * 2; i++) {

		    Transform point = Instantiate(pointPrefab,Vector3.zero, Quaternion.Euler(new Vector3(0, 0, 90)));

		    if (spawnState == 0) 
		    {
			    spawnPos += new Vector3(gapdistanceX, 0);
			    point.position = Camera.main.ViewportToWorldPoint(spawnPos);
			    if (i == horizontalCount - 1)
				    spawnState++;
		    } else if (spawnState == 1) 
		    {
			    spawnPos += new Vector3(0, -gapdistanceY);
			    point.position = Camera.main.ViewportToWorldPoint(spawnPos);
			    if (i == horizontalCount + verticalCount - 2)
				    spawnState++;
		    } else if (spawnState == 2) 
		    {
			    spawnPos += new Vector3(-gapdistanceX, 0);
			    point.position = Camera.main.ViewportToWorldPoint(spawnPos);
			    if (i == horizontalCount * 2 + verticalCount - 3)
				    spawnState++;
		    } else
		    {
			    spawnPos += new Vector3(0, gapdistanceY);
			    point.position = Camera.main.ViewportToWorldPoint(spawnPos);
		    }
		    //point.localPosition = new Vector3(0.5f, 0, 0) * i;
		    
	    }   
	   

    }
	
	void Start () {
		
	}
	
	void Update () {
	}
}
