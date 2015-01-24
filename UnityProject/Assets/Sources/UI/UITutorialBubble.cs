using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class UITutorialBubble : MonoBehaviour {

	public Text textLabel;

	// Use this for initialization
	void Start () {
		ShowText ("hello vorld hello vorld hello vorld hello vorld hello vorld");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowText(string value){
		const float ONE_LETTER_DURATION = 0.05f;
		DOTween.To(()=>textLabel.text, x=>textLabel.text = x, value, ONE_LETTER_DURATION * value.Length); 
	}

}
