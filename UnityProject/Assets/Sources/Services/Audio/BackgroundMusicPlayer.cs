using UnityEngine;
using System.Collections;

public class BackgroundMusicPlayer : MonoBehaviour {

	void Awake()
	{
		GameObject.DontDestroyOnLoad(gameObject);
	}

	public void Play(AudioClip clip)
	{
		audio.clip = clip;
		audio.Play();
	}
}
