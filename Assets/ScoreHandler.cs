using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour {

	PlayerController playerController;

	void OnTriggerEnter2D(Collider2D playerCollider)
	{
		if (playerCollider.gameObject.tag.Equals("Player")) {
			playerController.setScore ();
		}
		Debug.Log ("bird score = " + playerController.GetScore ());
	}

	// Use this for initialization
	void Start () {
		
		playerController = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
