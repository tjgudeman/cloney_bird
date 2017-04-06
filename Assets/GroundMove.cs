using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour {

	Rigidbody2D player;
	float speed = 0f;


	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		if (player_go == null) {
			Debug.LogError ("Could not find an object with player tag");
			return;
		}

		player = player_go.GetComponent<Rigidbody2D> ();


	}



	void FixedUpdate () {
		float vel = player.velocity.x * 0.75f;
		transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
		
	}
}
  