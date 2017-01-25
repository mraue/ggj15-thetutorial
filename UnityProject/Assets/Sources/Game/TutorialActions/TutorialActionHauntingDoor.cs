using UnityEngine;

namespace GGJ15.TheTutorial
{
	public class TutorialActionHauntingDoor : TutorialAction
	{
		public PlayerController player;
		public GameObject theDoor;

		const float _maxSpeed = 2f;
		float _currentSpeed = 0f;
		Vector3 _startingPos;

		bool _isActive;

		void Start()
		{
			_startingPos = theDoor.transform.position;
		}

		public override float Activate()
		{
			float duration = 0f;
			Log.Info("TUTORIAL HAUNTING DOOR : ACTIVATE");
			_isActive = true;
			return duration;
		}

		public override void ResetLevel()
		{
			Log.Info("TUTORIAL HAUNTING DOOR : RESET LEVEL");
			theDoor.transform.position = _startingPos;
			_isActive = false;
		}

		void FixedUpdate()
		{
			if (_isActive
				&& player.GetComponent<Rigidbody2D>().velocity.x < 0f)
			{
				_currentSpeed += 0.08f;
				_currentSpeed = System.Math.Min(_currentSpeed, _maxSpeed);
				var position = theDoor.transform.position;
				position.x -= _currentSpeed * Time.fixedDeltaTime;
				theDoor.transform.position = position;
			}
			else
			{
				_currentSpeed = 0f;
			}

		}
	}
}