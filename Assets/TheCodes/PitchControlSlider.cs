using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchControlSlider : MonoBehaviour {


	public AudioSource m_MyAudioSource;
	public float m_MySliderValue;

	[Header("Where the slider is positioned")]
	public float pitchSliderPosX; 
	public float pitchSliderPosY; 


	void Start () {

		//Initiate the Slider value to half way
		m_MySliderValue = 0.5f;
		//Fetch the AudioSource from the GameObject
		m_MyAudioSource = GetComponent<AudioSource>();
		//Play the AudioClip attached to the AudioSource on startup
		m_MyAudioSource.Play();

	}


	void OnGUI()
	{
		//Create a horizontal Slider that controls volume levels. Its highest value is 1 and lowest is 0
		m_MySliderValue = GUI.VerticalSlider(new Rect(pitchSliderPosX, pitchSliderPosY, 200, 60), m_MySliderValue, 0.0F, 1.0F);

		//Makes the volume of the Audio match the Slider value
		m_MyAudioSource.pitch = m_MySliderValue;
	}

}
