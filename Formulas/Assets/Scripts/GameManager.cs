﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager> 
{
	// Asset
	public GameObject actorHealthBar;

	protected override void Awake()
	{
		base.Awake();

		MonsterConfigs.Init();
	}
}
