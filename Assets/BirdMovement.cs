using System.Collections;
using UnityEngine;

public class BirdMovement : MonoBehaviour {

	Vector3 velocity = Vector3.zero;

	float flapSpeed = 100f;
	float forwardSpeed = 1f;

	bool didFlap = false;
	Animator animation;

	bool dead = false;
	public bool godMode = false;

	// Use this for initialization
	void Start () {
		animation = transform.GetComponentInChildren<Animator> ();
		
	}



	void Update(){
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			didFlap = true;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (dead) {
			return;
		}
		GetComponent<Rigidbody2D> ().AddForce (Vector2.right * forwardSpeed);

		if (didFlap) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * flapSpeed);

			animation.SetTrigger ("New_Flap");
			didFlap = false;
		}

		if (GetComponent<Rigidbody2D> ().velocity.y > 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		} 
		else {
			float angle = Mathf.Lerp (0, -90, -GetComponent<Rigidbody2D> ().velocity.y / 3f);
			transform.rotation = Quaternion.Euler (0, 0, angle);
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		if (godMode) {
			return;
		}
		animation.SetTrigger ("Death");
		dead = true;
	}

}
 