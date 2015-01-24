using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public class TutorialStepList
	{
		public List<List<TutorialStep>> steps { get; set; }

		public TutorialStepList()
		{
			steps = new List<List<TutorialStep>>
			{
				new List<TutorialStep>
				{
					new TutorialStep
					{
						text = "Yeah, we did it",
						duration = 2f,
						actions = new List<TutorialActionId> { TutorialActionId.DoorArrows }
					},
					new TutorialStep
					{
						text = "Yeah, we did it",
						duration = 2f,
						actions = new List<TutorialActionId> { TutorialActionId.DoorArrows }
					}
				}
			};
		}
	}
}