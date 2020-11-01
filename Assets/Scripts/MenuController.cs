using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
        Score.score = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
