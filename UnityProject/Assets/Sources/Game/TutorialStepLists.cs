using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public class TutorialStepLists
	{
		public List<List<TutorialStep>> steps { get; set; }

		public TutorialStepLists()
		{
			steps = new List<List<TutorialStep>>
			{
				new List<TutorialStep>
				{
					new TutorialStep
					{
						text = "Yeah, we did it",
						duration = 2f,
						actions = new List<TutorialActionId> { }
					},
					new TutorialStep
					{
						text = "Totally dude",
						duration = 2f,
						actions = new List<TutorialActionId> { TutorialActionId.DoorArrows }
					}
				}
			};
		}
	}
}