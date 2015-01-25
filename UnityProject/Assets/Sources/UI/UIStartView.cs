using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using DG.Tweening;

namespace GGJ15.TheTutorial
{
	public class UIStartView : MonoBehaviour
	{	
		public Image backgroundImage;

		public List<AnimationClip> animationList;
		int _currentAnimationIndex;
		int _lastAnimationToPlayIndex;
		Animation _animation;
		int _levelMax;

		public Text congratsLabel;

		AudioId[] _cheerSounds = new AudioId[] { AudioId.Cheer2, AudioId.Cheer3, AudioId.Cheer4, AudioId.Cheer5, AudioId.Cheer6, AudioId.Cheer7, AudioId.Cheer8, AudioId.Cheer9, AudioId.Cheer10 };

		void Awake()
		{
			_animation = GetComponent<Animation>();
			_currentAnimationIndex = int.MaxValue;
		}

		public void OnStart()
		{
			Services.currentInstance.audioService.PlaySound(AudioId.ButtonContinueClick);

			Hide(false);
			GameContext.currentInstance.director.OnUIStart();
		}

		public void ActivateCameraShake()
		{
			Camera.main.GetComponent<CameraShake>().DoShake();
		}

		public void StartAnimation(int level)
		{
			StartPanelAnimationClear[] animationObjects = GetComponentsInChildren<StartPanelAnimationClear>();
			foreach(var obj in animationObjects)
				obj.Disable ();
			
			Debug.Log("StartAnimation");
			_currentAnimationIndex = 0;
			_lastAnimationToPlayIndex = Mathf.Min (level + 1, animationList.Count - 1);

			string[] congratsOptions=new string[]{
				"Congratulations!",
				"Spectacular!",
				"Mind Shattering!",
				"Expectations Exceeded!",
				"Fantastic!",
				"Impressive!",
				"Funtastic!",
				"Superb Execution!",
				"Wow!",
				"Hopefully someone else saw that!",
				"History has been made this day!",
				"Hot DAYUM!!",
				"You taught me to believe in the power of my dreams!",
				"Best player yet!",
				"Other tutorials would be jealous!",
				"Your performance moved us all.",
				"I like how you move",
				"Moves like Jäger",
				"Fastest time yet!",
				"Finally, a decent player!",
				"Yours is the movement that will pierce the heavens!",
				"Such Moves!",
				"Bellissimo!",
				"Fantastico!",
				"Straordinario!",
				"Incredible!",
				"First Try! Wow!"
			};

			if (_levelMax == 0)
				congratsLabel.text = congratsOptions[0];
			else
				congratsLabel.text = congratsOptions[Random.Range(0,congratsOptions.Length)];



		}

		void Update()
		{
			if(!_animation.isPlaying && _currentAnimationIndex < _lastAnimationToPlayIndex){
				_currentAnimationIndex++;
				Debug.Log ("UIStartView:Update - Play animation "+animationList[_currentAnimationIndex].name);
				_animation.Play (animationList[_currentAnimationIndex].name);
			}
		}

		public void Show()
		{
			//	_animation.CrossFade("Show");
			

			AudioId cheerEffect = _cheerSounds[Random.Range(0, _cheerSounds.Length)];
			Services.currentInstance.audioService.PlaySound(cheerEffect);

			float animationTime = 0.2f;
			
			backgroundImage.color = Color.clear;
			backgroundImage.transform.localScale = Vector3.zero;
			
			backgroundImage.transform.DOScale(Vector3.one, animationTime).SetEase(Ease.OutBack, 1.1f);
			backgroundImage.DOColor(Color.white, 0.1f);
			
		}

		public void Hide(bool animated = true)
		{
		//	_animation.CrossFade("Hide");

			float animationTime = (animated) ? 0.1f : 0f;
			backgroundImage.DOColor(Color.clear, animationTime);

			
			//backgroundImage.transform.localScale = Vector3.zero;
			backgroundImage.transform.DOScale(Vector3.zero, animationTime).SetEase(Ease.OutBack, animationTime);
		}

	}
}