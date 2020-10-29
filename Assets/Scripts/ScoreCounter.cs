using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private Text ScoreText;

    private int score;
    public int Score { get => score; set => score = value; }

    /*public static void IncrementScore(int increment)
    {
        score += increment;
    }*/

    /*public static void SetScore(int newScore)
    {
        score = newScore;
    }*/

    void Update()
    {
        ScoreText.text = $"Score: {score}";
    }
}