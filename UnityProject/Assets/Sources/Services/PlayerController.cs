using UnityEngine;
using System.Collections;
using DG.Tweening;

namespace GGJ15.TheTutorial
{
	public class PlayerController : MonoBehaviour {

		public float speed = 5f;
		public GameObject startPos;

		public GameObject playerSprite;

		bool allowMovement = false;
		//bool directionRight = true;

		// Use this for initialization
		void Start () {
			initPlayer();
			spawnPlayer();

		}

		void initPlayer (){
			transform.position = new Vector2();
			transform.position = startPos.transform.position;
			gameObject.GetComponent<Rigidbody2D>().Sleep();
			playerSprite.GetComponent<SpriteRenderer>().color = Color.clear;
			//rigidbody2d.isKinematic = true;
		}

		void spawnPlayer(){
			//rigidbody2d.isKinematic = false;
			gameObject.GetComponent<Rigidbody2D>().WakeUp();
			allowMovement = true;
			playerSprite.GetComponent<SpriteRenderer>().DOColor(Color.white,0.5f);
		}
		
		// Update is called once per frame
		void FixedUpdate () {
			if (allowMovement){
				float move = Input.GetAxis ("Horizontal");
				rigidbody2D.velocity = new Vector2(move * speed, rigidbody2D.velocity.y);
			}
		}
		
		void OnTriggerEnter2D (Collider2D other) {
			//Debug.Log ("hello");
			GameContext.currentInstance.director.CharacterReachedDoor();
		}
		
		void OnTriggerExit2D (Collider2D other) {
			//Debug.Log ("goodbye");
		}

		void Awake(){
			GameContext.currentInstance.playerController = this;
		}

	}
}