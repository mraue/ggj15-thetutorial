﻿using UnityEngine;
using System.Collections;

public class BackgroundMusicPlayer : MonoBehaviour
{
	void Awake()
	{
		GameObject.DontDestroyOnLoad(gameObject);
	}
}
