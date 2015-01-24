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
							text = "Lesson 1: Movement",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "Press D to move left",
							duration = 2f,
							actions = new List<TutorialActionId> { }
						}
					},
					eventSteps = new Dictionary<GameEventId, TutorialStep>
					{
						{ 
							GameEventId.ReachedLeftCollider,
							new TutorialStep
							{
								text = "PRESS D TO MOVE LEFT",
								duration = 2f,
								actions = new List<TutorialActionId> { TutorialActionId.DoorArrows }
							}
						},
						{ 
							GameEventId.PassedCenter,
							new TutorialStep
							{
								text = "AWESOME JOB! KEEP GOING",
								duration = 2f,
								actions = new List<TutorialActionId> { TutorialActionId.DoorArrows }
							}
						},
					}
				}
			};
		}
	}
}