using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour {


	void OnTouch()
	{
		if (Input.touchCount > 0) {
			Touch firstTouch = Input.touches [0];
			if (firstTouch.deltaPosition.x > 15) {
				transform.Translate (20*Time.deltaTime, 0, 0);

			}

			if (firstTouch.deltaPosition.x < -15) {
				transform.Translate (-20*Time.deltaTime, 0, 0);
			}

			if (firstTouch.deltaPosition.y > 15) {
				transform.Translate (0, 20*Time.deltaTime, 0);
			}

			if (firstTouch.deltaPosition.y < -15) {
				transform.Translate (0, -20*Time.deltaTime, 0);
			}
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		OnTouch ();
		
	}
}
