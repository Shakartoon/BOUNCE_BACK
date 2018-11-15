using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funnymovement : MonoBehaviour {

	public Transform from;
	public Transform to;
	public float speed = 0.1F;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 randompoint = new Vector3 (Random.Range(-1,4),Random.Range(-7,7 ));

		gameObject.transform.position=Vector3.Lerp(gameObject.transform.position,randompoint,Time.deltaTime*1f);

		gameObject.transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.time * speed);
	
	}
}

//public float MaxSpeed;
//public float TimeScale;
//public float RefreshTime;
//public int AntPositionsSaved;
//public Dictionary<int, Vector3> AntPositions;
//public bool ShowPathBool;
//public LineRenderer TunnelLine;
//// Use this for initialization
//void Start ()
//{
//	StartCoroutine(SavePosition());
//	AntPositions = new Dictionary<int, Vector3>();
//}
//
//// Update is called once per frame
//void FixedUpdate ()
//{
//	Time.timeScale = TimeScale;
//	transform.Translate(transform.right * Time.deltaTime * MaxSpeed * Time.deltaTime);
//}
//
//void ShowPath()
//{
//	TunnelLine.SetVertexCount(AntPositionsSaved);
//	foreach (KeyValuePair<int, Vector3> pair in AntPositions)
//	{
//		//draw line
//		TunnelLine.SetPosition(pair.Key, pair.Value);
//	}
//	Debug.Log("Finished drawing line");
//}
//
//IEnumerator SavePosition()
//{
//	yield return new WaitForSeconds(RefreshTime);
//	AntPositionsSaved++;
//	AntPositions.Add(AntPositionsSaved, this.gameObject.transform.position);
//	ShowPath();
//	StartCoroutine(SavePosition());
//	Debug.Log("Ant position is: " + this.gameObject.transform.position);
//}
//}
