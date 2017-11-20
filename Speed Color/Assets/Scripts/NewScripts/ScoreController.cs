﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public int score;
    public Text scoreText;

	// Use this for initialization
	void Start () {
        score = 0;

    }

    // Update is called once per frame
    void Update () {
        UpdateScore();
	}

    public void UpdateScore()
    {
        scoreText.text = "" + score;
    }
}
