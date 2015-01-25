namespace GGJ15.TheTutorial
{
	public class TutorialEventStep : TutorialStep
	{
		public GameEventId eventId { get; set; }

		public int eventCount { get; set; }

		public bool executeOnlyOnce { get; set; }
	}
}