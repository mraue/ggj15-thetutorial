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
				// LEVEL 3
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
							text = "This time we will make it easy for you",
							duration = 1f,
							actions = new List<TutorialActionId> { TutorialActionId.HauntingDoor }
						},
						new TutorialStep
						{
							text = "Just a little notch along the way",
							duration = 1f,
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
								duration = 1f,
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
								duration = 1f,
								actions = new List<TutorialActionId> { },
								blockPlayerMovement = true
							}
						},
						{
							new TutorialEventStep
							{
								eventId = GameEventId.PlayerReachedExit,
								text = "I MEAN IT",
								duration = 1f,
								actions = new List<TutorialActionId> { },
								blockPlayerMovement = true
							}
						},
						{
							new TutorialEventStep
							{
								eventId = GameEventId.PlayerReachedExit,
								text = "YOU ARE",
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
							text = "Press forward",
							duration = 3f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "You know ...",
							duration = 5f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "It must be easy to be a player ...",
							duration = 5f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "You’re young, strong, handsome and ..",
							duration = 3f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = " ... entertaining.",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "Now look at me",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "an old, repetitive script, ...",
							duration = 3f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. teaching obvious things to stupid pl...ehm",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. amazing players!",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "I was a player, once.",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "I could beat the tutorial:",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "explore fantastic worlds, .. ",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. fight dragons, with my powerful weapons, ..",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "and save princes.",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "You know what, kid, I was the best around.",
							duration = 3f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "I wasn’t just a hero, I was The Hero,",
							duration = 3f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "but then, yes, ...",
							duration = 3f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "... ",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "I met the prince of the 98th level ..",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. such a wonderful guy ..",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. we fell in love and got married.",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "I don’t regret it, but you know how it goes:",
							duration = 5f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "you have children,  ..",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "... you need a safe and secure job, ..",
							duration = 5f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. solid career perspectives, and .. ",
							duration = 5f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. and life falls into boredom:",
							duration = 5f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. no more 589,768 lives lost every day ..",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = " .. no more late night adventures ..",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. no more \"The End\" parties.",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "I should have listened to my parents",
							duration = 3f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "\"Sta lontano dal mondo dei videogiochi!\".",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "Listen to your parents!",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "You know, it’s hard to find others.. ",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. who understand you.",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "Thanks for listening, ..",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "... you are real pal!",
							duration = 4f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "What were we doing ..",
							duration = 5f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = ".. ah yes: The Door!",
							duration = 5f,
							actions = new List<TutorialActionId> { },
							continuesTutorial = true
						},						
					},
					eventSteps = new List<TutorialEventStep>
					{						
					}
				},
			};
		}
	}
}