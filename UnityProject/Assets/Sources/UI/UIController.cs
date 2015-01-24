﻿using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class UIController : MonoBehaviour
	{
		public UIStartView startView;

		public UIEndView endView;

		void Awake()
		{
			GameContext.currentInstance.uiController = this;
		}
	}
}