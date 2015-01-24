using UnityEngine;
using System.Collections;

namespace GGJ15.TheTutorial
{
	public class Director : MonoBehaviour
	{	

		void Awake()
		{
			Application.LoadLevelAdditive("UI");
			GameContext.currentInstance.director = this;
		}

		void Start()
		{
			GameContext.currentInstance.uiController.startView.Show();
		}

		public void CharacterReachedDoor()
		{
			Debug.Log("Director knows player is at exit");
		}
	}
}
