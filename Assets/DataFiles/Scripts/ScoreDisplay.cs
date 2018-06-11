﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Mcalculator mcalc;
	int monsterCount = 0;
	public Text monsterText;

	void Start () {
		mcalc = FindObjectOfType<Mcalculator> ();
		monsterCount = mcalc.counter;
		monsterText.text = monsterCount.ToString ();
		Destroy (mcalc.gameObject);
	}
}