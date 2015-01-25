using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class UITutorialBubble : MonoBehaviour {

	public Text textLabel;
	public Image backgroundImage;

	Tweener _textTweener;

	void Start () {
		Hide(false);

	}	

	public void SetText(string value){
		const float ONE_LETTER_DURATION = 0.05f;
		if (_textTweener != null)
		{
			_textTweener.Kill();
		}
		textLabel.text = "";
		_textTweener = DOTween.To(()=>textLabel.text, x=>textLabel.text = x, value, ONE_LETTER_DURATION * value.Length); 
	}

	public void Show(string value){

//		GGJ15.TheTutorial.Services.currentInstance.audioService.PlaySound(GGJ15.TheTutorial.AudioId.TutorialPopup);

		float animationTime = 0.2f;

		backgroundImage.color = Color.clear;
		backgroundImage.transform.localScale = Vector3.zero;

		backgroundImage.transform.DOScale(Vector3.one, animationTime).SetEase(Ease.OutBack, 1.1f);
		backgroundImage.DOColor(Color.white, 0.1f);
		//textLabel.DOColor(Color.black, animationTime);

//		backgroundImage.DOColor(Color.white, animationTime);
//		textLabel.DOColor(Color.white, animationTime);
//		backgroundImage.transform.DOShakeScale(0.5f);

		SetText (value);

	}

	public void Hide(bool animated = true){
		float animationTime = (animated) ? 0.1f : 0f;
		backgroundImage.DOColor(Color.clear, animationTime);
		textLabel.text = "";
		//textLabel.DOColor(Color.clear, animationTime);
	}


}
