using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public class TutorialStep
	{
		public string text { get; set; }

		public float duration { get; set; }

		public List<TutorialActionId> actions { get; set; }

		public bool blockPlayerMovement { get; set; }

		public bool continuesTutorial { get; set; }
	}
}