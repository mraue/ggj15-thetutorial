using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 5f;
	bool directionRight = true;

	bool atExit = false;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity = new Vector2(move * speed, rigidbody2D.velocity.y);
	}
	
	void OnTriggerEnter2D (Collider2D other) {
		Debug.Log ("hello");
		atExit = true;
	}
	
	void OnTriggerExit2D (Collider2D other) {
		Debug.Log ("goodbye");
		atExit = false;
	}

	bool returnExit (){
		return atExit;
	}

}
