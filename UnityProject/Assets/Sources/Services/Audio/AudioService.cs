using System;
using UnityEngine;
using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public class AudioService : MonoBehaviour
	{
		public AudioRegistry audioRegistry;

		public void Play(AudioId audioId)
		{
			// Not using a dictionary for now, so the sound can easily be exchanged in the editor
			for(int i=0; i<audioRegistry.audioMap.Count; i++)
			{
				var item = audioRegistry.audioMap[i];

				if(item.audioId == audioId && item.audioClip != null && item.audioClip.isReadyToPlay)
				{
					try
					{
						AudioSource.PlayClipAtPoint(item.audioClip, Vector3.zero);
					}
					catch(Exception ex)
					{
						Log.Error("AUDIO : Failed to play sound for "+audioId.ToString(), ex.Message + ex.StackTrace);
					}
					break;
				}
			}
		}
	}
}