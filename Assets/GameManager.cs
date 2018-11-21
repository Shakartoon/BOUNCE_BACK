using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	

	private AudioSource myAudioSource;
	private bool isPaused = false; 
	private float timeScale;
	private InstantiateBeatBall InstantiateBeatBallScript; 

	// Use this for initialization
	void Start () {
		
		InitializeServices ();
		myAudioSource = gameObject.AddComponent<AudioSource> ();
	}

	private void InitializeServices() {
		Services.Clock = gameObject.AddComponent<Clock> ();
		Services.Clock.Initialize ();
		Services.Clock.SetBPM (90);

		Services.Clock.eventManager.Register<Quarter> (_Tick);
		// Clock.eventManager.Register<ThirtySecond(_ThirtySecond);

		Services.Clips = Resources.Load ("Clips") as ClipLibrary;
	}

	private void _Tick(BeatEvent e) {
		myAudioSource.clip = Services.Clips.Tick;
		myAudioSource.loop = false;
		myAudioSource.Play ();
	}

	private void _ThirtySecond(BeatEvent e) {
		
	}

	void Update()
	{
	}
}
