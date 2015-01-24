using System;
using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public class TutorialLevel
	{
		public List<TutorialStep> steps { get; set; }

		public Dictionary<GameEventId, TutorialStep> eventSteps { get; set; }
	}
}