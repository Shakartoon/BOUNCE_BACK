using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragToAimLoop : MonoBehaviour {

	public GameObject myTriangle;
	public GameObject mainBallPlayer;
	public Rigidbody2D mainBallPlayerRB;

	public GameObject player; // why do i need two player game objects? 

	public float distance;	// Distance between this and the center of the ball
	public float maxLength;

	private float currentScaleAmount; 

	Transform mainBall;
	public MouseClick mouseClick;
	public float defaultLength; 
	public float shrinkSpeed;
	float length;
	bool prevDraggin;
	bool hasBall;
	Vector3 defPos;

	void Start () {
		hasBall = true;
		mainBall = GameObject.Find ("mainBall2").transform;
		mainBallPlayer = GameObject.Find ("mainBall2");
		defPos = mainBall.position;
		mouseClick = transform.GetChild (0).GetComponent<MouseClick> ();
		SetLength (defaultLength);
		mainBallPlayerRB = mainBallPlayer.GetComponent<Rigidbody2D> ();
	}

	void Update () {
		Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		if (mouseClick.isMouseDragging && hasBall){

			float angle = Mathf.Atan2 (mousePosition.x - mainBall.position.x, mousePosition.y - mainBall.position.y);

			transform.position = mainBall.position + new Vector3(Mathf.Sin(angle) * distance, Mathf.Cos(angle)*distance);
			transform.eulerAngles = new Vector3 (0, 0, -angle * Mathf.Rad2Deg + 180);
			SetLength(Mathf.Min ((mousePosition - (Vector2)mainBall.position).magnitude - distance, maxLength));

			Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
			Debug.DrawRay(transform.position, forward, Color.green);

		} else {
			SetLength (Mathf.Max(length - shrinkSpeed * Time.deltaTime, defaultLength));
		}
		if (prevDraggin && !mouseClick.isMouseDragging && hasBall){
			hasBall = false;
			mainBallPlayerRB.isKinematic = false;
			mainBallPlayerRB.AddForce (((Vector2)mainBallPlayer.transform.position - mousePosition) * 4f, ForceMode2D.Impulse);
		}
	//	if (!hasBall && (mainBallPlayerRB.isKinematic || mainBall.transform.position.y < -15f)) {

		if (!hasBall && (mainBallPlayerRB.isKinematic || mainBall.transform.position.y < -7f)) {
				
			mainBallPlayer = Instantiate (mainBallPlayer, defPos, Quaternion.identity);
			mainBallPlayerRB = mainBallPlayer.GetComponent<Rigidbody2D> ();
			mainBallPlayerRB.isKinematic = true;
			mainBall = mainBallPlayer.transform;
			hasBall = true;
		}

		prevDraggin = mouseClick.isMouseDragging;

	}

	void SetLength(float l){
		length = l;
		Transform sprite = transform.GetChild (0);
		sprite.localScale = new Vector3 (sprite.localScale.x, length, sprite.localScale.z);
		sprite.localPosition = new Vector3(0,-length * 0.5f);
	}

}
