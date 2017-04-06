using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	static public int score_1 = 0;
	static int highscore = 0;

	static public void AddPoint(){
		score_1++;

		if (score_1 > highscore) {
			highscore = score_1;
		}

	}


	// Update is called once per frame
//	void Update () {
//		UICompenonet temp = GameObject.FindWithTag ("UI_Text");
//		temp.text = "Score: " + score_1 + "\n High Score: " + highscore;
//		
//	}
}
