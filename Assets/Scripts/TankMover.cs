using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankMover : MonoBehaviour
{
    //speed of moving forward/backward
    [SerializeField]
    private float Speed = 0.1f;

    //speed of turning
    [SerializeField]
    private float TurnSpeed = 1f;

    void Update()
    {
        //move forwards with W or up arrow 
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        
        //move backwards with S or down arrow
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            transform.Translate(Vector3.back * Speed * Time.deltaTime);

        //turn left with A or left arrow
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(0, -TurnSpeed * Time.deltaTime, 0);
        
        //turn right with D or right arrow
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(0, TurnSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider c)
    {
        //ends game if player collides with an enemy
        if (c.gameObject.CompareTag("Enemy"))
        {
            //unlocks the cursor for the end screen
            Cursor.lockState = CursorLockMode.None;

            //sets a new high score if old high score is broken
            if (Score.score > Score.getHighScore())
                Score.setHighScore();

            //loads the end scene
            SceneManager.LoadScene("End");
        }
    }
}
