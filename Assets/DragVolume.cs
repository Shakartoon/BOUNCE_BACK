using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class DragVolume : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private AudioSource myAS;
    private float screenWidthNumber;

    private float minVolume = 0f;
    private float maxVolume = 1f;

    public float distorTimeAmnt = 0f;
    public float doppler_Level = 0f;

    private SpriteRenderer mySR; 
    
    void Start()
    {
        myAS = GetComponent<AudioSource>();
        mySR = GetComponent<SpriteRenderer>(); 

    }

    void OnMouseOver()
    {
        mySR.color = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 2f)); 

    }
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, screenPoint.z));
        
        mySR.color = Color.black;


    }
 
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, 0, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
                              transform.position = curPosition;
        
        mySR.color = Color.black;
 
    }

    void OnMouseExit()
    {
        mySR.color = Color.white; 
    }

    void Update()
    {

        Vector3 tmpPos = Camera.main.WorldToScreenPoint(transform.position);
        Debug.Log(tmpPos.x);

        float xPos = transform.position.x;

        //change values from 0 - 1 
        float adjusted = xPos + 5;
        myAS.volume = adjusted / 10;
       // myAS.time = adjusted / distorTimeAmnt;
        myAS.dopplerLevel = doppler_Level; 

    } 

}
