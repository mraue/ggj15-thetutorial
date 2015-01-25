using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public partial class TutorialStepLists
	{
		// LEVEL 2
		TutorialLevel _level2 = new TutorialLevel
		{
			steps = new List<TutorialStep>
			{
				new TutorialStep
				{
					text = "Lesson {n}: Movements",
					duration = 2f,
					actions = new List<TutorialActionId> { },
					blockPlayerMovement = true
				},
				new TutorialStep
				{
					text = "Press arrow to move",
					duration = 2f,
					actions = new List<TutorialActionId> { }
				}
			},
			eventSteps = new List<TutorialEventStep>
			{
				{ 
					new TutorialEventStep
					{
						eventId = GameEventId.ReachedLeftCollider,
						text = "I thought we talked about this ...",
						duration = 2f,
						actions = new List<TutorialActionId> { TutorialActionId.DoorGrows },
						continuesTutorial = true,
						eventCount = 1,
						executeOnlyOnce = true
					}
				},
				{ 
					new TutorialEventStep
					{
						eventId = GameEventId.PassedCenter,
						text = "YOU ARE A GENIUS!",
						duration = 2f,
						actions = new List<TutorialActionId> { },
						executeOnlyOnce = true,
					}
				},
				{ 
					new TutorialEventStep
					{
						eventId = GameEventId.PassedCenter,
						text = "WAY TO GO!",
						duration = 2f,
						actions = new List<TutorialActionId> { },
						executeOnlyOnce = true,
						eventCount = 1
					}
				},
				{ 
					new TutorialEventStep
					{
						eventId = GameEventId.PlayerReachedExit,
						text = "YOU ARE THE BEST!!",
						duration = 1f,
						actions = new List<TutorialActionId> { },
						blockPlayerMovement = true
					}
				},
			}
		};
	}
}
