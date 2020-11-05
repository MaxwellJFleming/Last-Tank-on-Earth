using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//the script used to show the final score
public class FinalScore : MonoBehaviour
{
    [SerializeField]
    private Text ScoreText;

    void Update()
    {
        ScoreText.text = $"FINAL SCORE: {Score.score}";
    }
}
