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
		}
	}
}

