using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class TutorialActionRemoveDoor : TutorialAction
	{
		public GameObject theDoor;

		public override float Activate()
		{
			float duration = 0f;
			Log.Info("TUTORIAL REMOVE DOOR : ACTIVATE");
			theDoor.SetActive(false);
			return duration;
		}

		public override void ResetLevel()
		{
			Log.Info("TUTORIAL REMOVE DOOR : RESET LEVEL");
			theDoor.SetActive(true);
		}
	}
}
