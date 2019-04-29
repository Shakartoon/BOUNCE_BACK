using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickRotateEffect : MonoBehaviour {

    void OnMouseDown()
    {
        
        
       //transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 80));
       //transform.localPosition += new Vector3(1 / 2, 0, 0);
 
       transform.SetPositionAndRotation(new Vector3(-0.17f, -1.29f, 22.06f), Quaternion.Euler(0, 0, 90 - 1 * Time.time));

    }
    
    
}
