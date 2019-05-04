using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class ImmigrationAudioMixer : MonoBehaviour
{
	public AudioMixer audioMixer;
	public ImmigrationLevelManager LMScript; 
	
	public void SetFlangeLevel(float FlangeRate)
	{
		if (LMScript.PlayerIsOnTheRight)
		{
			//increase Flange 
			audioMixer.SetFloat("FlangeRate", 10); 
		}
	}
	
}
