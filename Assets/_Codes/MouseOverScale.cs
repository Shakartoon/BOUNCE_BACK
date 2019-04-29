using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOverScale : MonoBehaviour
{
	
	
	public void OnMouseEnter() 
	{
		transform.localScale += new Vector3(0.1F, 0.1F, 0F);
	}
     
	public void OnMouseOver()
	{
		transform.localScale += new Vector3(0.1F, 0.1F, 0F);
	}
         
	public void OnMouseExit()
	{
		transform.localScale += new Vector3(0F, 0F, 0F);    
	}

} 
