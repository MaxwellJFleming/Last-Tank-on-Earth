using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehavior : MonoBehaviour
{
    //time between firing bullets
    [SerializeField]
    private float FireInterval = 0.25f;

    //keeps track of how long it's been since you've fired
    private float timer = 0;

    private float reloadTimer = 0;

    //number of bullets that can be fired before having to reload
    [SerializeField]
    private int ClipSize = 10;

    //initial velocity of the bullets
    [SerializeField]
    private float BulletSpeed = 10f;
    
    //bullet prefab
    [SerializeField]
    private GameObject Bullet;

    //AudioSource component of the bullet spawner
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private float reloadTime = 3;

    [SerializeField]
    private GameObject ReloadText;



    //initializes the clip
    private void Start()
    {
        Clip.clipSize = ClipSize;
        Clip.reload();
    }

    void Update()
    {
        timer += Time.deltaTime;

        //fires a bullet if:
        //1) you clicked the left mouse button
        //2) it's been at least {FireInterval} seconds since you fired the cannon
        //3) there's at least 1 bullet left in your clip
        //4) you're not currently reloading
        if (Input.GetMouseButtonDown(0) && timer >= FireInterval && Clip.clip > 0 && !Clip.reloading)
        {
            //removes a bullet from your clip
            Clip.fire();
            
            //spawns a bullet
            GameObject b = Instantiate(Bullet, transform.position, transform.rotation);

            //immediately adds force to the bullet
            b.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * BulletSpeed * Time.deltaTime);

            //plays the firing sound
            audioSource.Play();

            //sets the timer back to 0
            timer = 0;
        } else if (Input.GetMouseButtonDown(0) && timer >= FireInterval && Clip.clip == 0 && !Clip.reloading)
        {
            //if the only thing missing is that there's no bullets left, displays a message telling you to reload
            ReloadText.SetActive(true);
            
        }

        //begins the reload process on right mouse click if there are less than clipSize bullets left
        if (Input.GetMouseButtonDown(1) && Clip.clip < Clip.clipSize && !Clip.reloading)
        {
            Clip.reloading = true;
        }

        if (Clip.reloading)
        {
            reloadTimer += Time.deltaTime;
            
            if (reloadTimer >= reloadTime)
            {
                Clip.reload();
                Clip.reloading = false;
                reloadTimer = 0;
            }
        }
    }
}