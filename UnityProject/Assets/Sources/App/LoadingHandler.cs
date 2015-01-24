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
			Services.currentInstance.audioService.PlayMusic(AudioId.MainTheme);
			Services.currentInstance.audioService.PlaySound(AudioId.ButtonClick);
			Application.LoadLevel(MAIN_SCENE);
		}
	}
}