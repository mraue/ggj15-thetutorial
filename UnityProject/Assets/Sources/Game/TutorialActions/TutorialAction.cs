using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class TutorialAction : MonoBehaviour
	{
		public virtual float Activate()
		{
			float duration = 0f;
			return duration;
		}

		public virtual void ResetStep() {}

		public virtual void ResetLevel() {}
	}	
}