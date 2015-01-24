using UnityEngine;
using System.Collections;

namespace GGJ15.TheTutorial
{
	public class LoadingHandler : MonoBehaviour
	{
		public const string MAIN_SCENE = "Main";

		void Start()
		{
		}

		public void OnStart()
		{
			Application.LoadLevel(MAIN_SCENE);
		}
	}
}