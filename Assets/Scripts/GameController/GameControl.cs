﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public static int score, numOfMissiles;
    private int highScore;
    public Text scoreText, highScoreText, missileAmount;

	// Use this for initialization
	void Start () {

        // Starting game variables
        score = 0;
        numOfMissiles = 50;

        // UI text
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("High Score");
        UpdateMissiles();
        UpdateScore();

    }// End Start
	
	// Update is called once per frame
	void Update () {

	}

    // Adds to current score and updates it in the UI
    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }

    // Will update the UI with the new score
    public void UpdateScore()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }

    public void subtractMissiles(int numOfMissiles)
    {

        GameControl.numOfMissiles--;
        UpdateMissiles();

    }

    public void UpdateMissiles()
    {
        missileAmount.text = "Missiles: " + GameControl.numOfMissiles;
    }

}