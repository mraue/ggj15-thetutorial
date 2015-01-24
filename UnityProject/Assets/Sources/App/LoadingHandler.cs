using UnityEngine;
using System.Collections;

namespace GGJ15.TheTutorial
{
	public class LoadingHandler : MonoBehaviour
	{
		public const string MAIN_SCENE = "Main";

		public void OnStart()
		{
			Services.currentInstance.audioService.PlaySound(AudioId.ButtonClick);
			StartCoroutine(LoadMainSceneDelayed(0.4f));
		}

		IEnumerator LoadMainSceneDelayed(float delay)
		{
			yield return new WaitForSeconds(delay);
			Application.LoadLevel(MAIN_SCENE);
		}
	}
}