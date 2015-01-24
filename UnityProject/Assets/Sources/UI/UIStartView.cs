using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class UIStartView : MonoBehaviour
	{
		Animation _animation;

		void Awake()
		{
			_animation = GetComponent<Animation>();
		}

		public void OnStart()
		{
			Hide();
			GameContext.currentInstance.director.OnUIStart();
		}

		public void Hide()
		{
			_animation.CrossFade("Hide");
		}

		public void Show()
		{
			_animation.CrossFade("Show");
		}
	}
}