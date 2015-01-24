using System;
using UnityEngine;
using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	[Serializable]
	public class TutorialActionPair
	{
		public TutorialActionId id;
		public TutorialAction action;
	}

	public class TutorialActionRegistry : MonoBehaviour
	{
		public List<TutorialActionPair> tutorialActionMap;

		public TutorialAction GetAction(TutorialActionId id)
		{
			TutorialAction action = null;

			foreach (var item in tutorialActionMap)
			{
				if (item.id == id)
				{
					action = item.action;
					break;
				}
			}

			return action;
		}

		public void ResetStep()
		{
			foreach (var item in tutorialActionMap)
			{
				item.action.ResetStep();
			}
		}

		public void ResetLevel()
		{
			foreach (var item in tutorialActionMap)
			{
				item.action.ResetLevel();
			}
		}

	}
}