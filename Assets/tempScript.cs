using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempScript : MonoBehaviour {


public float MaxSpeed;
public float TimeScale;
public float RefreshTime;
public int AntPositionsSaved;
public Dictionary<int, Vector3> AntPositions;
public bool ShowPathBool;
public LineRenderer TunnelLine;
// Use this for initialization
void Start ()
{
	StartCoroutine(SavePosition());
	AntPositions = new Dictionary<int, Vector3>();
}

// Update is called once per frame
void FixedUpdate ()
{
	Time.timeScale = TimeScale;
	transform.Translate(transform.right * Time.deltaTime * MaxSpeed * Time.deltaTime);
}

void ShowPath()
{
	TunnelLine.SetVertexCount(AntPositionsSaved);
	foreach (KeyValuePair<int, Vector3> pair in AntPositions)
	{
		//draw line
		TunnelLine.SetPosition(pair.Key, pair.Value);
	}
	Debug.Log("Finished drawing line");
}

IEnumerator SavePosition()
{
	yield return new WaitForSeconds(RefreshTime);
	AntPositionsSaved++;
	AntPositions.Add(AntPositionsSaved, this.gameObject.transform.position);
	ShowPath();
	StartCoroutine(SavePosition());
	Debug.Log("Ant position is: " + this.gameObject.transform.position);
}
}


