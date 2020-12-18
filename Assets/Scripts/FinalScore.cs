using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//the script used to show the final score
public class HighScoreDisplay : MonoBehaviour
{
    [SerializeField]
    private Text HighScoreDisplayText;

    void Update()
    {
        HighScoreDisplayText.text = $"HIGH SCORE: {Score.getHighScore()}";
    }
}
