using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	static int test;
	int var = 2;

	IEnumerator AddSum(){
		while (true) {
			var *= 2;
			Debug.Log (var);
//			yield return new WaitForSeconds(2);
		}

	}

	void StartGame(){
	
	
	}
	// Use this for initialization
	void Start () {

		StartCoroutine (AddSum());


	}
	
	// Update is called once per frame
	void Update () {


		
	}
}
