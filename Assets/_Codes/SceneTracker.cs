using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement; 


public class SceneTracker : MonoBehaviour {

	public int lastLevelPlayer = 0;
	public int TimesPlayedLevel1 = 0; 

	public static SceneTracker me;

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
	}
	
}