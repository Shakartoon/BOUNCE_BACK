using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class WeaponSelect_State : State
{
	#region Private Variables
	[SerializeField] DisplayObject[] _dependantContent;
	#endregion

	#region Flow
	void OnEnable ()
	{
		foreach (var item in _dependantContent)
		{
			item.SetActive (true); 
		}
	}

	void OnDisable ()
	{
		foreach (var item in _dependantContent)
		{
			item.SetActive (false); 
		}
	}
	#endregion
}