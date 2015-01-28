using UnityEngine;
using DG.Tweening;

namespace GGJ15.TheTutorial
{
	public class TutorialActionNightIsFalling : TutorialAction
	{
		public SpriteRenderer darkOverlay;
		public SpriteRenderer moon;
		public Transform moonContainer;
		Tweener _tweener1;
		Tweener _tweener2;
		Tweener _tweener3;

		AudioSource _audioSource;

		const float _duration = 20f;

		void Awake()
		{
			_audioSource = GetComponent<AudioSource>();
		}

		public override float Activate()
		{
			Log.Info("TUTORIAL ACTION NIGHT IS FALLING: ACTIVATE");
			darkOverlay.gameObject.SetActive(true);
			_tweener1 = darkOverlay.DOFade(1f, _duration);
			_tweener2 = moon.DOFade(1f, _duration);
			_tweener3 = moonContainer.DORotate(new Vector3(0, 0, 0), _duration).OnComplete(_audioSource.Play);
			return _duration;
		}

		public override void ResetLevel()
		{
			_tweener1.Kill();
			_tweener2.Kill();
			_tweener3.Kill();

			var color = darkOverlay.color;
			color.a = 0f;
			darkOverlay.color = color;

			color = moon.color;
			color.a = 0f;
			moon.color = color;

			moonContainer.DORotate(new Vector3(0, 0, 20), 0);

			if (_audioSource.isPlaying)
			{
				_audioSource.Stop();
			}

			Log.Info("TUTORIA ACTION NIGHT IS FALLING: RESET LEVEL");
		}
	}	
}

