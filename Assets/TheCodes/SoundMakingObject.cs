using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMakingObject : MonoBehaviour {

	public AudioManager am; 
	public AudioClip mySound; 

	public SpriteRenderer sprite;
	public SpriteRenderer ballSprite;
	float scaleVel;
	float currentScaleAmount;
	Vector2 defScale;

	public Clock.BeatValue quantizeDistance = Clock.BeatValue.Eighth; // if set to Measure, will wait for next measure, if set to half, next half, quarter, next quarter, etc.
	private AudioSource myAudioSource;

	public float pitchValue = 0.1f; 

	public CollisionAnimations colAnim;

	[Header("Sexy Colors")] 

	private Color salmonColor = new Color(); 
	public string salmonColorHex = "#F08080"; 

	private Color pinkColor = new Color(); 
	public string pinkColorHex = "#F35FBD"; 

	void Start () {
		myAudioSource = GetComponent<AudioSource> ();
		myAudioSource.clip = mySound; 
		sprite = GetComponent<SpriteRenderer> ();
		defScale = transform.localScale;
		currentScaleAmount = 1;
	
		colAnim.enabled = false; 

		ColorUtility.TryParseHtmlString (salmonColorHex, out salmonColor);
		ColorUtility.TryParseHtmlString (pinkColorHex, out pinkColor);

		//colAnim = GetComponent<ScriptNameToDisable>();

	}

	void Update() {
		
	} 

	void FixedUpdate () {
		scaleVel += (1f - currentScaleAmount) * .2f;
		scaleVel *= .92f;
		currentScaleAmount += scaleVel;
		transform.localScale = new Vector2 (defScale.x * (1f / currentScaleAmount), defScale.y * currentScaleAmount);
	}

	IEnumerator GotHit(){
		colAnim._scaleVelocity += .1f; 
		scaleVel += .1f;
		//R G B A 
		//sprite.color = salmonColor; 
		//sprite.color = new Color (0.3f, 0.1f, 0.4f, 0.3f);

		sprite.color = pinkColor; 
		yield return  new WaitForSeconds(0.1f);
		sprite.color = Random.ColorHSV ();
		yield return  new WaitForSeconds(0.05f);
		sprite.color = Random.ColorHSV ();
		yield return  new WaitForSeconds(0.05f);
		sprite.color = Random.ColorHSV ();
		yield return  new WaitForSeconds(0.05f);
		sprite.color = Random.ColorHSV ();
		yield return  new WaitForSeconds(0.05f);
		sprite.color = Random.ColorHSV ();
		yield return  new WaitForSeconds(0.05f);
		sprite.color = Random.ColorHSV ();
		yield return  new WaitForSeconds(0.05f);
		sprite.color = Color.white;

		//yield return  new WaitForSeconds(Services.Clock.SixteenthLength());

	}

	private void PlaySound() {
		Services.audioManager.Play (mySound); 
		StartCoroutine (GotHit ());
	}

	void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.CompareTag ("Ball")) {
			
			Services.Clock.SyncFunction (PlaySound, quantizeDistance);
			colAnim.enabled = true; 
		} 
			
			// Services.Clips.Scream;

			// FlatFX flatfx=GameObject.Find("FlatFXTest1").GetComponent<FlatFX>();
			// flatfx.AddEffect(Vector2.zero,0);
			// transform.Rotate (Time.deltaTime, 200, 0); 
	}


	
}
