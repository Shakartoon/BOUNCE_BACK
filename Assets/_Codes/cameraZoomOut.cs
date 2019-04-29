using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoomOut : MonoBehaviour
{

    public GameObject parent1;
 
    public float targetCameraSize;
    public float speed; 


    IEnumerator ZoomOut()
    {
        while (Camera.main.orthographicSize < targetCameraSize)
        {
            Camera.main.orthographicSize += speed * 0.5f; 
            yield return new WaitForSeconds(0.1f);
        }
        yield return null;
    }
    
    void Update()
    {

        if (parent1 == null)
        {

            StartCoroutine(ZoomOut()); 

        }
        
    }
    

}
