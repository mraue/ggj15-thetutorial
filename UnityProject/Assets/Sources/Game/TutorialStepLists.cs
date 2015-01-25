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
				// LEVEL 1
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
				},
				// LEVEL 2
				new TutorialLevel
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
				},
				// LEVEL 4
				new TutorialLevel
				{
					steps = new List<TutorialStep>
					{
						new TutorialStep
						{
							text = "Lesson {n}: Movement",
							duration = 2f,
							actions = new List<TutorialActionId> { TutorialActionId.NightIsFalling },
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
				},
			};
		}
	}
}