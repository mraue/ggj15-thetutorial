using UnityEngine;
using DG.Tweening;

namespace GGJ15.TheTutorial
{
	public class TutorialActionRemoveDoor : TutorialAction
	{
		public SpriteRenderer theDoorSprite;
		public GameObject theDoor;

		public Tweener _tweener;

		public override float Activate()
		{
			float duration = 0f;
			Log.Info("TUTORIAL REMOVE DOOR : ACTIVATE");
			_tweener = theDoorSprite.DOFade(0f, 4f).OnComplete(() => theDoor.gameObject.SetActive(false));
			return duration;
		}

		public override void ResetLevel()
		{
			Log.Info("TUTORIAL REMOVE DOOR : RESET LEVEL");
			_tweener.Kill();
			theDoor.gameObject.SetActive(true);
			_tweener = theDoorSprite.DOFade(1f, 0);
		}
	}
}
