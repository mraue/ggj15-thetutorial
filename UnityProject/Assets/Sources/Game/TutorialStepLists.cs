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
							text = "Yeah, we did it",
							duration = 10f,
							actions = new List<TutorialActionId> { }
						},
						new TutorialStep
						{
							text = "Totally dude",
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
								text = "Totally dude",
								duration = 2f,
								actions = new List<TutorialActionId> { TutorialActionId.DoorArrows }
							}
						}
					}
				}
			};
		}
	}
}