using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

namespace GGJ15.TheTutorial
{
	public class UIStartView : MonoBehaviour
	{

		public Image backgroundImage;

		public List<AnimationClip> animationList;
		int _animationIndex = 0;
		Animation _animation;
		int _levelMax;

		void Awake()
		{
			_animation = GetComponent<Animation>();
		}

		public void OnStart()
		{
			Hide(false);
			GameContext.currentInstance.director.OnUIStart();
		}

		public void StartAnimation(int level)
		{
			Debug.Log("StartAnimation");
			_animationIndex = 0;
			_animation.Play (animationList[_animationIndex].name);
			_animationIndex = 1;
			_animation.Play (animationList[_animationIndex].name);
			_levelMax = level;

		}

		void Update()
		{
			if(!_animation.isPlaying && _animationIndex <= _levelMax){
				_animationIndex++;
				Debug.Log ("UIStartView:Update - Play animation "+animationList[_animationIndex].name);
				_animation.Play (animationList[_animationIndex].name);
			}

		}

		public void Show()
		{
			//	_animation.CrossFade("Show");
			
			
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