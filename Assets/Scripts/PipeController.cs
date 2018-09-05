using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour {

	public Transform startPoint;
	public Transform endPoint;
	private float screenUpperBound = 1.3f;
	private float screenLowerBound = -0.6f;
	private void pipesMovementHandler()
	{
		if (!PlayerController.isGameOver) {
			transform.position += Vector3.left * 0.02f;
		}
		if (transform.position.x < startPoint.position.x) {
			transform.position = endPoint.position;
			transform.position = new Vector3 (transform.position.x, makeRandomPosition(), transform.position.y);
		}


	}

	private float makeRandomPosition()
	{
		float pipeYRandPos = Random.Range (screenLowerBound, screenUpperBound);
		return pipeYRandPos;
	}

	private void initialPipePositionHandler()
	{

		transform.position = new Vector3 (transform.position.x, makeRandomPosition (), transform.position.z);
	}

	// Use this for initialization
	void Start () {

		initialPipePositionHandler ();
		
	}
	
	// Update is called once per frame
	void Update () {
		pipesMovementHandler ();
		

		
	}
}
