using System; 
using UnityEngine.Audio;  
using UnityEngine; 

public class AudioManager : MonoBehaviour { 

	public Sounds[] mySounds;

	void Awake () {
	
		foreach (Sounds s in mySounds) {
			s.source = gameObject.AddComponent<AudioSource>();  
			s.source.clip = s.clip; 
			s.source.volume = s.volume; 
			s.source.pitch = s.pitch; 
		
		}  
	} 
	
	// Update is called once per frame
	public void Play (string name) {

		Sounds s = Array.Find (mySounds, sounds => sounds.name == name);  
		s.source.Play (); 
		
	}

	public void Play (AudioClip clip) {
		AudioSource.PlayClipAtPoint(clip, transform.position);

	}
}
