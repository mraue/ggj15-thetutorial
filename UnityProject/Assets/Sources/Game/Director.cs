using UnityEngine;
using System.Collections;

namespace GGJ15.TheTutorial
{
	public class Director : MonoBehaviour
	{	
		public TutorialActionRegistry tutorialActionRegistry;

		UIController _uiController;
		PlayerController _playerController;

		void Awake()
		{
			Application.LoadLevelAdditive("UI");
			GameContext.currentInstance.director = this;
		}

		void Start()
		{
			_uiController = GameContext.currentInstance.uiController;
			_playerController = GameContext.currentInstance.playerController;
			_playerController.spawnPlayer();
			GameContext.currentInstance.uiController.tutorialBubbleView.Show("MOVE RIGHT");
		}

		public void CharacterReachedDoor()
		{
			GameContext.currentInstance.uiController.tutorialBubbleView.Hide();

			_uiController.startView.Show();
			_playerController.setMovement(false);
		}

		public void OnUIStart()
		{
			_playerController.initPlayer();
			Start();
		}
	}
}
