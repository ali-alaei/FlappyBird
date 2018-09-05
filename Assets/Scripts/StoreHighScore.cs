using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreHighScore : MonoBehaviour {


	void SortScores()
	{
		int [] highScores= new int [] {20, 30 , 40 ,50 ,60};
		int currentScore = 35;
		if (currentScore > highScores[0]) {
			highScores [0] = currentScore;
		}

		for (int i = 0; i < highScores.Length; i++) {
			if (highScores[i] > highScores [i + 1]) {
				int tmp;
				tmp = highScores [i+1];
				highScores [i] = highScores [i+1];
			}
		}

		for (int i = 0; i < highScores.Length; i++) {
			Debug.Log (highScores [i]);
		}
	}

	void Start()
	{

		SortScores ();

	}



}
	
