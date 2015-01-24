using System;
using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class Services : MonoBehaviour
	{
		public static Services currentInstance
		{
			get
			{
				return _currentInstance;
			}
		}
		static Services _currentInstance;

		public AudioService audioService
		{
			get
			{
				return _audioService;
			}
		}
		AudioService _audioService;


		void Awake()
		{
			if (Services.currentInstance == null)
			{
				_currentInstance = this;
			}
			else
			{
				GGJ15.TheTutorial.Log.Error("SERVICE : CURRENT INSTANCE IS ALREADY SET");
			}

			_audioService = GetComponentInChildren<AudioService>();
		}
	}
}

