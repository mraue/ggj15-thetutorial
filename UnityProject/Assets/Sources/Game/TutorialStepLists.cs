using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public partial class TutorialStepLists
	{
		public List<TutorialLevel> levels { get; set; }

		public TutorialStepLists()
		{
			levels = new List<TutorialLevel>
			{
					_level3,
				_level1,
				_level2,
				_level4,
				_level5,
			};
		}
	}
}