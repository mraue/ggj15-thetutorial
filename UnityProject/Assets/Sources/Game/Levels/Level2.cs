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
					duration = 1.5f,
					actions = new List<TutorialActionId> { },
					blockPlayerMovement = true
				},
				new TutorialStep
				{
					text = "Press arrow to move",
					duration = 12f,
					actions = new List<TutorialActionId> { }
				},
				new TutorialStep
				{
					text = "How do you call ..",
					duration = 2f,
					actions = new List<TutorialActionId> { }
				},
				new TutorialStep
				{
					text = ".. a quest for answers?",
					duration = 4f,
					actions = new List<TutorialActionId> { }
				},
				new TutorialStep
				{
					text = "Question.",
					duration = 4f,
					actions = new List<TutorialActionId> { }
				},
				new TutorialStep
				{
					text = "That's right.",
					duration = 12f,
					actions = new List<TutorialActionId> { }
				},
				new TutorialStep
				{
					text = "How about that door over there?",
					duration = 4f,
					actions = new List<TutorialActionId> { TutorialActionId.DoorArrows }
				},
				new TutorialStep
				{
					text = "It's shiny.",
					duration = 4f,
					actions = new List<TutorialActionId> { }
				},
				new TutorialStep
				{
					text = "I know you want it too ..",
					duration = 4f,
					actions = new List<TutorialActionId> { }
				},
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
