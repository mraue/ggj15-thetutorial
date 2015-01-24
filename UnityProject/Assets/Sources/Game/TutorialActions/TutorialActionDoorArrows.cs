using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class TutorialActionDoorArrows : TutorialAction
	{
		Animation _animation;

		void Awake()
		{
			_animation = GetComponent<Animation>();
		}

		public override float Activate()
		{
			float duration = 0f;
			_animation.CrossFade("DoorArrowsActivate");
			return duration;
		}
	}	
}