using UnityEngine;
using System.Collections;

namespace GGJ15.TheTutorial
{
	public class Director : MonoBehaviour
	{	
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
		}

		public void CharacterReachedDoor()
		{
			_uiController.startView.Show();
		}

		public void OnUIStart()
		{
		}
	}
}
