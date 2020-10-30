using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    #region Instance
    //makes a static instance of the ScoreCounter in-game
    public static ScoreCounter instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion

    [SerializeField]
    private Text ScoreText;

    private int score;

    public void IncrementScore(int increment)
    {
        score += increment;
    }

    public void SetScore(int newScore)
    {
        score = newScore;
    }

    void Update()
    {
        ScoreText.text = $"Score: {score}";
    }
}