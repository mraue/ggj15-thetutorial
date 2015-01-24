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
	}
}