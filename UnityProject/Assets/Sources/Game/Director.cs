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

		int _currentLevel;

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
						tutorialActionRegistry.ResetStep();
						_currentStep = _currentTutorialSteps[_currentTutorialStep];
						_uiController.tutorialBubbleView.Show(_currentStep.text);

						foreach (var actionId in _currentStep.actions)
						{
							TutorialAction action = tutorialActionRegistry.GetAction(actionId);
							if (action != null)
							{
								action.Activate();
							}
						}

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
					Log.Info("DIRECTOR: TUTORIAL FINISHED " + _currentTutorialLevel);
					_tutorialIsActive = false;
				}
			}
		}

		public void CharacterReachedDoor()
		{
			_uiController.startView.Show();
			CleanupLevel();
		}

		void CleanupLevel()
		{
			GameContext.currentInstance.uiController.tutorialBubbleView.Hide();
			_playerController.setMovement(false);
			tutorialActionRegistry.ResetLevel();
		}

		public void OnUIStart()
		{
			_currentLevel += 1;
			Log.Info("DIRECTOR: STARTING NEXT LEVEL " + _currentLevel);
			_playerController.initPlayer();
			_playerController.spawnPlayer();
			StartTutorial(_currentTutorialLevel);
		}
	}
}
