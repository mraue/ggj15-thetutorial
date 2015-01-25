using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class TutorialSlowyPushyAction : TutorialAction {

		Animation _animation;
		
		void Awake()
		{
			_animation = GetComponent<Animation>();
		}
		
		public override float Activate()
		{
			Log.Info("TUTORIAL SLOW BLOCK PUSHER : ACTIVATE !!!!");
			gameObject.SetActive(true);
			float duration = 0f;
			_animation.CrossFade("SlowBlockPusherActivate");
			return duration;
		}
		
		public override void ResetLevel()
		{
			gameObject.SetActive(false);
			Log.Info("TUTORIAL SLOW BLOCK PUSHER : RESET LEVEL");
		}
	}
}
