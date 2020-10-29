using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMover : MonoBehaviour
{
    [SerializeField]
    private float Speed = 0.1f;

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

    private void OnTriggerEnter(Collision c)
    {
        if (c.gameObject.CompareTag("Enemy"))
        {
            
        }
    }
}
