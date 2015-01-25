using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public class TutorialStepLists
	{
		public List<TutorialLevel> levels { get; set; }

		public TutorialStepLists()
		{
			levels = new List<TutorialLevel>
			{
				new TutorialLevel
				{
					steps = new List<TutorialStep>
					{
						new TutorialStep
						{
							text = "Lesson {n}: Movement",
							duration = 2f,
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
								text = "PRESS D TO MOVE LEFT",
								duration = 2f,
								actions = new List<TutorialActionId> { TutorialActionId.SlowyPushyAction },
								continuesTutorial = true,
							}
						},
						{ 
							new TutorialEventStep
							{
								eventId = GameEventId.PassedCenter,
								text = "AWESOME JOB! KEEP GOING",
								duration = 2f,
								actions = new List<TutorialActionId> { TutorialActionId.DoorArrows }
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
				},
				new TutorialLevel
				{
					steps = new List<TutorialStep>
					{
						new TutorialStep
						{
							text = "Lesson {n}: Movement",
							duration = 2f,
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
								text = "I thought we talked about this ...",
								duration = 2f,
								actions = new List<TutorialActionId> { TutorialActionId.DoorGrows },
								continuesTutorial = true,
								eventCount = 2,
							}
						},
						{ 
							new TutorialEventStep
							{
								eventId = GameEventId.PassedCenter,
								text = "AWESOME JOB! KEEP GOING",
								duration = 2f,
								actions = new List<TutorialActionId> { TutorialActionId.DoorArrows }
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
				}
			};
		}
	}
}