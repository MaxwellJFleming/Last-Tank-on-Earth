using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    #region Instance
    //makes a static instance of the GameManagerScript in-game
    public static GameManagerScript instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion 

    public Transform player;

    public void GameOver()
    {
        SceneManager.LoadScene("End");
    }
}
