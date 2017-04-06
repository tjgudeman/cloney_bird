using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGLooper : MonoBehaviour {
	
	int numBGPanels = 6;
	float pipeMax = .542f;
	float pipeMin = -0.476f;

	void Start(){
		GameObject[] pipes = GameObject.FindGameObjectsWithTag ("Pipe");
		foreach (GameObject pipe in pipes) {
			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range (pipeMin, pipeMax);
			pipe.transform.position = pos;
		}
	}


	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log ("Triggered: " + collider.name);

		float widthOfBGObj =((BoxCollider2D)collider).size.x;

		Vector3 pos = collider.transform.position;
		pos.x += widthOfBGObj * numBGPanels;
		collider.transform.position = pos;

		if (collider.tag == "Pipe") {

			pos.y = Random.Range (pipeMin, pipeMax);
			
		}

	}
}
