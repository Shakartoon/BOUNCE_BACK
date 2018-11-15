using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode] 
public class ParticleTrigger : MonoBehaviour {

	public ParticleSystem ps; 

	public List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>(); 
	public List<ParticleSystem.Particle> exit = new List<ParticleSystem.Particle>(); 

	 
	void OnEnable()
	{
		ps = GetComponent<ParticleSystem> (); 


	}

	void OnParticleTrigger()
	{
		int enterParticleNumber = ps.GetTriggerParticles (ParticleSystemTriggerEventType.Enter, enter); 
		int exitParticleNumber = ps.GetTriggerParticles (ParticleSystemTriggerEventType.Exit, exit); 

		for (int i = 0; i < enterParticleNumber; i++) {
			ParticleSystem.Particle p = enter [i]; 
			p.startColor = new Color32 (255, 0, 100, 200); 
			enter [i] = p; 
		}

		for (int i = 0; i < exitParticleNumber; i++) {
			ParticleSystem.Particle p = exit [i]; 
			p.startColor = new Color32 (0, 200, 50, 50); 
			exit [i] = p; 
		}

		ps.SetTriggerParticles (ParticleSystemTriggerEventType.Enter, enter); 
		ps.SetTriggerParticles (ParticleSystemTriggerEventType.Exit, exit); 

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
