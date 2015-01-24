using System;
using UnityEngine;
using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	[Serializable]
	public class EventAudioClip
	{
		public AudioId audioId;
		public AudioClip audioClip;
	}
	
	public class AudioRegistry : MonoBehaviour
	{
		public List<EventAudioClip> audioMap;
	}
}
