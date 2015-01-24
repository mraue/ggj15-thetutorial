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
		Dictionary<GameEventId, TutorialStep> _currentTutorialEventSteps;

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
			if (_currentTutorialLevel < _tutorialStepList.levels.Count)
			{
				Log.Info("DIRECTOR: STARTING TUTORIAL " + _currentTutorialLevel);
				_currentTutorialSteps = _tutorialStepList.levels[_currentTutorialLevel].steps;
				_currentTutorialEventSteps = _tutorialStepList.levels[_currentTutorialLevel].eventSteps;
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
						StartCurrentStep();
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

		void StartCurrentStep()
		{
			tutorialActionRegistry.ResetStep();

			_uiController.tutorialBubbleView.Show(ReplaceText(_currentStep.text));

			foreach (var actionId in _currentStep.actions)
			{
				TutorialAction action = tutorialActionRegistry.GetAction(actionId);
				if (action != null)
				{
					action.Activate();
				}
			}

			_playerController.setMovement(!_currentStep.blockPlayerMovement);

			if (_currentStep.continuesTutorial)
			{
				_currentTutorialLevel += 1;
				_currentTutorialLevel = _currentTutorialLevel < _tutorialStepList.levels.Count
					? _currentTutorialLevel
					: _tutorialStepList.levels.Count - 1;
			}

			_timeStepStarted = Time.time;
		}

		string ReplaceText(string text)
		{
			return text.Replace("{n}", (_currentLevel + 1).ToString());
		}

		public void EndGame()
		{
			_uiController.startView.Show();
			_uiController.startView.StartAnimation(_currentLevel);
			_uiController.moneyHUDView.AddAmount(Random.Range(10000 * (_currentLevel + 1), 100000 * (_currentLevel + 1)));
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

		public void GameEventTriggered(GameEventId id)
		{
			Log.Info("DIRECTOR: GAME EVENT TRIGGERED " + id);

			if (_currentTutorialEventSteps != null)
			{
				TutorialStep step = null;

				_currentTutorialEventSteps.TryGetValue(id, out step);

				if (step != null)
				{
					Log.Info("DIRECTOR: GAME EVENT TRIGGERED STEP");
					_currentStep = step;
					StartCurrentStep();
				}

				if (id == GameEventId.PlayerReachedExit)
				{
					float delay = step != null ? step.duration : 0f;
					StartCoroutine(EndGameAfterDelay(delay));
				}
			}
		}

		IEnumerator EndGameAfterDelay(float delay)
		{
			yield return new WaitForSeconds(delay);
			EndGame();
		}
	}
}
