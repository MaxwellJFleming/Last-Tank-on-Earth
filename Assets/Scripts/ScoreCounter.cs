using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

//the code used by the in-game score counter
public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private Text ScoreText;

    void Update()
    {
        ScoreText.text = $"SCORE: {Score.score}";
    }
}