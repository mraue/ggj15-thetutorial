using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class UIEndView : MonoBehaviour
	{
		Animation _animation;

		void Awake()
		{
			_animation = GetComponent<Animation>();
		}

		public void OnContinue()
		{

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
