using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public partial class TutorialStepLists
	{
		// LEVEL 3
		TutorialLevel _level3 = new TutorialLevel
		{
			steps = new List<TutorialStep>
			{
				new TutorialStep
				{
					text = "Lesson {n}: Movements",
					duration = 1.5f,
					actions = new List<TutorialActionId> { },
					blockPlayerMovement = true
				},
				new TutorialStep
				{
					text = "This time we will make it easier for you",
					duration = 3f,
					actions = new List<TutorialActionId> { TutorialActionId.HauntingDoor },
					blockPlayerMovement = true
				},
				new TutorialStep
				{
					text = "Just a little notch along the way",
					duration = 3f,
					actions = new List<TutorialActionId> { }
				},
				new TutorialStep
				{
					text = "Remember: press right to go RIGHT",
					duration = 3f,
					actions = new List<TutorialActionId> { }
				}
			},
			eventSteps = new List<TutorialEventStep>
			{
				{ 
					new TutorialEventStep
					{
						eventId = GameEventId.PlayerReachedExit,
						text = "YOU ARE THE BEST!!",
						duration = 2f,
						actions = new List<TutorialActionId> { },
						blockPlayerMovement = true,
						continuesTutorial = true,
					}
				},
				{
					new TutorialEventStep
					{
						eventId = GameEventId.PlayerReachedExit,
						text = "NO REALLY",
						duration = 2f,
						actions = new List<TutorialActionId> { },
						blockPlayerMovement = true
					}
				},
				{
					new TutorialEventStep
					{
						eventId = GameEventId.PlayerReachedExit,
						text = "I MEAN IT",
						duration = 2f,
						actions = new List<TutorialActionId> { },
						blockPlayerMovement = true
					}
				},
				{
					new TutorialEventStep
					{
						eventId = GameEventId.PlayerReachedExit,
						text = "YOU ARE",
						duration = 2f,
						actions = new List<TutorialActionId> { },
						blockPlayerMovement = true
					}
				},
			}
					
		};
	}
}
