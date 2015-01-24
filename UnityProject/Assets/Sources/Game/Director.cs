using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GGJ15.TheTutorial
{
	public class Director : MonoBehaviour
	{	
		public TutorialActionRegistry tutorialActionRegistry;

		UIController _uiController;
		PlayerController _playerController;

		int _currentTutorialLevel;
		int _currentTutorialStep;
		TutorialStepLists _tutorialStepList = new TutorialStepLists();
		float _timeStepStarted;

		List<TutorialStep> _currentTutorialSteps;

		bool _tutorialIsActive;

		TutorialStep _currentStep;

		void Awake()
		{
			Application.LoadLevelAdditive("UI");
			GameContext.currentInstance.director = this;
		}

		void Start()
		{
			_uiController = GameContext.currentInstance.uiController;
			_playerController = GameContext.currentInstance.playerController;
			_playerController.spawnPlayer();
			GameContext.currentInstance.uiController.tutorialBubbleView.Show("MOVE RIGHT");
			GameContext.currentInstance.uiController.startView.Hide (false);
			StartTutorial(_currentTutorialLevel);
		}

		void StartTutorial(int _currentTutorialLevel)
		{
			if (_currentTutorialLevel < _tutorialStepList.steps.Count)
			{
				Log.Info("DIRECTOR: STARTING TUTORIAL " + _currentTutorialLevel);
				_currentTutorialSteps = _tutorialStepList.steps[_currentTutorialLevel];
				_tutorialIsActive = true;
				_currentTutorialStep = 0;
				_currentStep = null;
			}
		}

		void FixedUpdate()
		{
			if (_tutorialIsActive)
			{
				if (_currentTutorialStep < _currentTutorialSteps.Count)
				{
					if (_currentStep == null)
					{
						Log.Info("DIRECTOR: INITALIZING STEP " + _currentTutorialStep);
						_currentStep = _currentTutorialSteps[_currentTutorialStep];
						_uiController.tutorialBubbleView.Show(_currentStep.text);
						_timeStepStarted = Time.time;

					}

					if (Time.time > _timeStepStarted + _currentStep.duration)
					{
						_currentTutorialStep += 1;
						_currentStep = null;
						Log.Info("DIRECTOR: INCREASING STEP " + _currentTutorialStep);
					}
				}
				else
				{
					_tutorialIsActive = false;
				}
			}
		}

		public void CharacterReachedDoor()
		{
			GameContext.currentInstance.uiController.tutorialBubbleView.Hide();

			_uiController.startView.Show();
			_playerController.setMovement(false);
		}

		public void OnUIStart()
		{
			_playerController.initPlayer();
			Start();
		}
	}
}
