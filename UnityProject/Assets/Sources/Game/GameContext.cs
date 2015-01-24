using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class GameContext
	{
		public static GameContext currentInstance
		{
			get
			{
				if (_currentInstance == null)
				{
					_currentInstance = new GameContext();
				}
				return _currentInstance;
			}
		}
		static GameContext _currentInstance;

		public Director director { get; set; }

		public CharacterController characterController { get; set; }

		public UIController uiController { get; set; }
	}
}