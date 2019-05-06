using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement; 


public class SceneTracker : MonoBehaviour {

	public static SceneTracker me;

	//public int lastLevelPlayer = 0;
	public int TimesPlayedLevel1 = 0;
	public int TimesEnteredHubWorld = 0; 
	public int TimesPlayedImmigration; 
	public int TimesPlayedRugFringe; 
	public int TimesPlayedTriangle = 0; 
	
	//Keep track with an int 
	// each level needs it's own integer for how many times it's been played 
	//Start at hub world //set int and increase 
	//Increase times played by 1 and set int 
	
	void Start ()
	{
		if (me != null)
		{
			Destroy(gameObject);
			return;
		}

		me = this;
		DontDestroyOnLoad(gameObject);
		
		Debug.Log("Don't Destroy Called");
	}
	
}