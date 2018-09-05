using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	PlayerController playercontroller;
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag.Equals("Player")) {
			PlayerController.isGameOver = true;
			Debug.Log("GameOver");
			DisableAllPipes ();

		}

	}

	void DisableAllPipes()
	{
		GameObject[] pipes = GameObject.FindGameObjectsWithTag ("Pipe");
		foreach (var pipe in pipes) {
			pipe.GetComponent<BoxCollider2D> ().enabled = false;
		}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
