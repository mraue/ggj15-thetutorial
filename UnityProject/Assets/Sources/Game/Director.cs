using UnityEngine;
using System.Collections;

namespace GGJ15.TheTutorial
{
	public class Director : MonoBehaviour
	{	
		void Awake()
		{
			Application.LoadLevelAdditive("UI");
		}

		void Start()
		{
			GameContext.currentInstance.director = this;
		}

		public void CharacterReachedDoor()
		{

		}
	}
}
