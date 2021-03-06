﻿using UnityEngine;
using System.Collections;
using DG.Tweening;

namespace GGJ15.TheTutorial
{
	public class PlayerController : MonoBehaviour {

		public float speed = 6f;
		public GameObject startPos;

		public GameObject playerSprite;

		bool allowMovement = false;

		Vector3 initScale;

		AudioSource _audioSource;

		// Use this for initialization
		void Start () {
		}
		
		void Awake(){
			initScale = playerSprite.transform.localScale;
			initPlayer();
			GameContext.currentInstance.playerController = this;
			_audioSource = GetComponent<AudioSource>();
		}

		public void initPlayer (){
			transform.position = new Vector2();
			transform.position = startPos.transform.position;
			gameObject.GetComponent<Rigidbody2D>().Sleep();
			playerSprite.GetComponent<SpriteRenderer>().color = Color.clear;
		}

		public void spawnPlayer(){
			//rigidbody2d.isKinematic = false;
			gameObject.GetComponent<Rigidbody2D>().WakeUp();
			setMovement(true);
			playerSprite.GetComponent<SpriteRenderer>().DOColor(Color.white,0.5f);
		}

		public void despawnPlayer(){
			//rigidbody2d.isKinematic = false;
			playerSprite.GetComponent<SpriteRenderer>().DOColor(Color.clear,0.5f);

			if(_audioSource.isPlaying)
			{
				_audioSource.Stop();
			}
		}

		// Update is called once per frame
		void FixedUpdate () {
			if (allowMovement){
				float move = Input.GetAxis ("Horizontal");
				GetComponent<Rigidbody2D>().velocity = new Vector2(move * speed, GetComponent<Rigidbody2D>().velocity.y);


				bool Walking = Mathf.Abs(move) > 0.1f;
				playerSprite.GetComponent<Animator>().SetBool("Walking",Walking);

				if (Walking && !_audioSource.isPlaying)
				{
					_audioSource.Play();

				}
				else if (!Walking && _audioSource.isPlaying)
				{
					_audioSource.Stop();
				}

				if (GetComponent<Rigidbody2D>().velocity.x < 0)
					playerSprite.transform.localScale = new Vector3(-initScale.x,initScale.y,initScale.z);
				else
					playerSprite.transform.localScale = initScale;
			}
		}
		
		void OnTriggerExit2D (Collider2D other) {
			//Debug.Log ("goodbye");
		}

		public void setMovement(bool val){
			allowMovement = val;
			if  (!val)
				GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			if(!val)
				playerSprite.GetComponent<Animator>().SetBool("Walking",false);

			if(!allowMovement && _audioSource.isPlaying)
			{
				_audioSource.Stop();
			}
		}			
	}
}