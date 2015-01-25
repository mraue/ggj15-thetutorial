using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public partial class TutorialStepLists
	{

		// LEVEL 1
		TutorialLevel _level1 = new TutorialLevel
		{
			steps = new List<TutorialStep>
			{
				new TutorialStep
				{
					text = "Lesson {n}: Movement",
					duration = 1.5f,
					actions = new List<TutorialActionId> { },
					blockPlayerMovement = true
				},
				new TutorialStep
				{
					text = "Press right arrow to move right",
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
						text = "PRESS RIGHT ARROW TO MOVE RIGHT",
						duration = 2f,
						actions = new List<TutorialActionId> { TutorialActionId.SlowyPushyAction },
						executeOnlyOnce = true,
						continuesTutorial = true,
					}
				},
				{ 
					new TutorialEventStep
					{
						eventId = GameEventId.PassedCenter,
						text = "AWESOME JOB! KEEP GOING",
						duration = 2f,
						actions = new List<TutorialActionId> { TutorialActionId.DoorArrows },
						executeOnlyOnce = true
					}
				},
				{ 
					new TutorialEventStep
					{
						eventId = GameEventId.PlayerReachedExit,
						text = "YOU DID IT!!",
						duration = 1f,
						actions = new List<TutorialActionId> { },
						blockPlayerMovement = true
					}
				},
			}
		};				
	}
}