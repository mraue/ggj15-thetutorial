﻿using UnityEngine;
using System.Collections;

namespace GGJ15.TheTutorial
{
	public class ColliderEventReporter : MonoBehaviour
	{
		public GameEventId eventId;

		void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision.gameObject.GetComponent<PlayerController>() != null)
			{
				GameContext.currentInstance.director.GameEventTriggered(eventId);
			}
		}

		void OnTriggerEnter2D(Collider2D collider)
		{
			if (collider.gameObject.GetComponent<PlayerController>() != null)
			{
				GameContext.currentInstance.director.GameEventTriggered(eventId);
			}
		}
	}
}