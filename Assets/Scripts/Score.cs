using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
    //tracks the player's score thru all scenes
    public static int score = 0;

    //saves the current score to the high score
    public static void setHighScore()
    {
        PlayerPrefs.SetInt("High Score", score);
    }

    //gets the current high score
    public static int getHighScore()
    {
        return PlayerPrefs.GetInt("High Score", 0);
    }
}
