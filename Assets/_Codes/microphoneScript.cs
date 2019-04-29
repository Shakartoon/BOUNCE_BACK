using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microphoneScript : MonoBehaviour {

	public AudioSource AS; 

	void Start() {

		AS = GetComponent<AudioSource> (); 
		//1.Which microphone? 2. Do you want to loop it? 3.How long will the audio record for? 4. The frequency? 
		AS.clip = Microphone.Start("Built-in Microphone",false, 50, 44100); 
		AS.Play (); 

			foreach (string device in Microphone.devices) {
				Debug.Log("Name: " + device);

			} 
	}
}