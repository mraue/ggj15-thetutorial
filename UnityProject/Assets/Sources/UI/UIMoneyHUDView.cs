using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace GGJ15.TheTutorial
{
	public class UIMoneyHUDView : MonoBehaviour
	{
		public Text amountLabel;

		float _animateDuration = 1f;
		float _animateStart;
		bool _isAnimating;
		int _startAmount;
		int _finalAmount;
		int _currentAmount;

		public void AddAmount(int amount)
		{
			Services.currentInstance.audioService.PlaySound(AudioId.CoinsReceived);
			_startAmount = _finalAmount;
			_finalAmount = _startAmount + amount;
			_animateStart = Time.time;
			_isAnimating = true;
		}

		void FixedUpdate()
		{
			if (_isAnimating)
			{
				float currentTime = Time.time;

				if (currentTime < _animateStart + _animateDuration)
				{
					int amount = _startAmount +
					             (int)((float)(_finalAmount - _startAmount) * (currentTime - _animateStart) / _animateDuration);
					amountLabel.text = amount.ToString();
				}
				else
				{
					_isAnimating = false;
					amountLabel.text = _finalAmount.ToString();
				}
			}
		}
	}
}