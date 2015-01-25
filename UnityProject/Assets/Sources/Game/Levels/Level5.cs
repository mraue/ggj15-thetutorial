using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public partial class TutorialStepLists
	{
		TutorialLevel _level5 = new TutorialLevel
			{
				steps = new List<TutorialStep>
					{
						new TutorialStep
						{
							text = "Lesson ...",
							duration = 3f,
							actions = new List<TutorialActionId> { },
							blockPlayerMovement = true
						},
						new TutorialStep
						{
							text = "",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						}
					},
				eventSteps = new List<TutorialEventStep>
					{
					}
			};				
	}
}
