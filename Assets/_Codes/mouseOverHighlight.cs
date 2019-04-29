using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseOverHighlight : MonoBehaviour
{
    public GameObject highlightRectangle;
    public float zDistance;
    private Vector3 temp; 
    
    void Start()
    {
        highlightRectangle.SetActive(false);
    }
    void OnMouseOver()
    {
        highlightRectangle.SetActive(true);

        temp = new Vector3(transform.position.x, transform.position.y, transform.position.z - 5f);
        highlightRectangle.transform.position = temp; 
    }
    void OnMouseEnter()
    {
        
        
    }

    void OnMouseExit()
    
    {        highlightRectangle.SetActive(false);

    }


}
