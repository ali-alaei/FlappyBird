using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	[SerializeField] private GameObject flappyBird;
	private Collider2D birdCollider;
	private Rigidbody2D birdRigidBody;
	public Vector2 jumpForce;
	private int score = 0;
	public static bool isGameOver = false;
	public Text playerScore;
	private void clickHandler()
	{
		
		#if UNITY_EDITOR
		if (Input.GetKeyDown(KeyCode.M) && !isGameOver) {
			birdRigidBody.velocity = new Vector2(0,0);
			birdRigidBody.AddForce(jumpForce);
		}
		#endif

		#if UNITY_ANDROID
		if (Input.touchCount > 0) {
			Touch firstTouch = Input.touches [0];
			if (firstTouch.phase == TouchPhase.Began)
			{
				birdRigidBody.velocity = new Vector2(0,0);
				birdRigidBody.AddForce(jumpForce);
			}
		}
		#endif
	}

	public int GetScore()
	{
		return this.score;
		
	}

	public void setScore()
	{
		score++;
		playerScore.text = score.ToString ();
	}
	// Use this for initialization
	void Start () {
		birdRigidBody = flappyBird.GetComponent<Rigidbody2D> ();
		birdCollider = flappyBird.GetComponent<Collider2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		clickHandler ();
		
	}
}
