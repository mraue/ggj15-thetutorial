﻿using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class UIController : MonoBehaviour
	{
		public UIStartView startView;
		public UITutorialBubble tutorialBubbleView;
		public UIMoneyHUDView moneyHUDView;


		void Awake()
		{
			GameContext.currentInstance.uiController = this;
		}
	}
}