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

		TutorialStepLists _tutorialStepList = new TutorialStepLists();

		List<TutorialStep> _steps = new List<TutorialStep>();
		List<TutorialEventStep> _eventSteps;

		TutorialStep _currentStep;
		float _timeStepStarted;
		bool _tutorialIsActive;

		Dictionary<GameEventId, int> _eventCounter = new Dictionary<GameEventId, int>();
		List<TutorialEventStep> _preventStep = new List<TutorialEventStep>();

		bool _gameHasEnded;

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
			GameContext.currentInstance.uiController.startView.Hide(false);
			StartTutorial(_currentTutorialLevel);
		}

		void StartTutorial(int currentTutorialLevel)
		{
			if (currentTutorialLevel < _tutorialStepList.levels.Count)
			{
				Log.Info("DIRECTOR: STARTING TUTORIAL " + currentTutorialLevel);

				_steps = new List<TutorialStep>(_tutorialStepList.levels[currentTutorialLevel].steps);
				_eventSteps = _tutorialStepList.levels[currentTutorialLevel].eventSteps;

				_eventCounter.Clear();
				_preventStep.Clear();
				_currentStep = null;

				_tutorialIsActive = true;

				_gameHasEnded = false;
			}
		}

		void FixedUpdate()
		{
			if (_tutorialIsActive)
			{
				if (_steps.Count > 0)
				{
					if (_currentStep == null)
					{
						Log.Info("DIRECTOR: INITALIZING NEXT STEP");
						_currentStep = _steps[0];
						_steps.RemoveAt(0);
						StartCurrentStep();
					}

					if (Time.time > _timeStepStarted + _currentStep.duration)
					{
						_currentStep = null;
						Log.Info("DIRECTOR: MOVING TO NEXT STEP");
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

			if ( _gameHasEnded)
			{
				Log.Info("DIRECTOR: IGNORING EVENT");
				return;
			}

			int currentEventCount = 0;
			_eventCounter.TryGetValue(id, out currentEventCount);

			if (_eventSteps != null)
			{
				List<TutorialEventStep> eventSteps = new List<TutorialEventStep>();

				foreach (var step in _eventSteps)
				{
					if (!_preventStep.Contains(step)
						&& step.eventId == id
					    && currentEventCount >= step.eventCount)
					{
						eventSteps.Add(step);

						if (step.executeOnlyOnce)
						{
							_preventStep.Add(step);
						}
					}
				}					

				float delay = 0f;

				if (eventSteps.Count > 0)
				{
					Log.Info("DIRECTOR: GAME EVENT TRIGGERED STEP");
					_currentStep = eventSteps[0];
					delay += _currentStep.duration;
					StartCurrentStep();
					eventSteps.RemoveAt(0);

					if (id == GameEventId.PlayerReachedExit)
					{
						_steps.Clear();
					}

					for (int i = eventSteps.Count - 1; i > -1; i--)
					{
						var step = eventSteps[i];
						_steps.Insert(0, step);
						delay += step.duration;
					}
				}

				if (id == GameEventId.PlayerReachedExit)
				{
					_gameHasEnded = true;
					Services.currentInstance.audioService.PlaySound(AudioId.Cheer1);
					StartCoroutine(EndGameAfterDelay(delay));
				}
			}
				
			_eventCounter[id] = currentEventCount + 1;
		}

		IEnumerator EndGameAfterDelay(float delay)
		{
			yield return new WaitForSeconds(delay);
			EndGame();
		}
	}
}
