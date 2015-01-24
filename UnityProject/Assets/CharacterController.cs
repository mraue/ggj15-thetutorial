using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public float speed = 5f;
	bool directionRight = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float move = Input.GetAxis ("Horizontal");

		rigidbody2D.velocity = new Vector2(move * speed, rigidbody2D.velocity.y);


	}
}
