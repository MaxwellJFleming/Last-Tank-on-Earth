﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//the script used by the in-game score counter
public class ScoreCounter : MonoBehaviour
{
    [SerializeField]
    private Text ScoreText;

    void Update()
    {
        ScoreText.text = $"SCORE: {Score.score}";
    }
}