using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    [SerializeField]
    private Text ScoreText;

    void Update()
    {
        ScoreText.text = $"FINAL SCORE: {Score.score}";
    }
}
