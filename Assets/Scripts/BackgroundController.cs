using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour {

	public Transform startPoint;
	public Transform endPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!PlayerController.isGameOver) {
			transform.position += Vector3.right * 0.02f;
		}
		if (transform.position.x > endPoint.position.x) {

			transform.position = startPoint.position;
			float yPos = Random.Range (-4, 4);
			//transform.position = yPos;
		}
		
	}
}
