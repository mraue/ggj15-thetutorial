using UnityEngine;
using System;
using DG.Tweening;

namespace GGJ15.TheTutorial
{
	public class TutorialActionDoorGrows : TutorialAction
	{
		Transform _doorTransform;

		void Awake()
		{
			_doorTransform = GameObject.FindGameObjectWithTag("Door").transform;
		}

		public override float Activate()
		{
			Log.Info("TUTORIAL ACTION DOOR GROWS : ACTIVATE !!!!");
			gameObject.SetActive(true);
			float duration = 0f;
			_doorTransform.DOScale(Vector3.one * 13f, 8f).SetEase(Ease.InSine);
			return duration;
		}

		public override void ResetLevel()
		{
			_doorTransform.localScale = Vector3.one;
			gameObject.SetActive(false);
			Log.Info("TUTORIAL ACTION DOOR GROWS : RESET LEVEL");
		}
	}	
}
