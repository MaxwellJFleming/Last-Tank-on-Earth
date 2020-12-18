using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    //How far the enemy can see the player from
    [SerializeField]
    private float LookRadius = 50f;

    //the enemy's AudioSource
    [SerializeField]
    private AudioSource audioSource;

    //the AudioClips to play when this enemy dies
    public AudioClip[] enemyDeathSounds;

    //the player's transform
    private Transform target;
    
    //the NavMeshAgent component of the enemy
    private NavMeshAgent agent;

    //the time between footstep sounds
    [SerializeField]
    private float footstepInterval = 0;
    
    private float footstepTimer = 0;
    
    void Start()
    {
        target = GameManagerScript.instance.player;
        agent = GetComponent<NavMeshAgent>();
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= LookRadius)
        {
            //moves the enemy towards the player if it's within sight
            agent.SetDestination(target.position);
            
            //adds to footstepTimer every frame it's moving
            footstepTimer += Time.deltaTime;

            //plays the footstep sound and resets footstepTimer if it's been {footstepInterval} seconds
            if (footstepTimer > footstepInterval)
            {
                audioSource.Play();
                footstepTimer = 0;
            }
        }
    }

    //kills the enemy if it's hit by a bullet
    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Bullet"))
        {
            //plays a random death sound
            audioSource.clip = Utility.randomAudioClip(enemyDeathSounds);
            audioSource.Play();

            //destroys the bullet
            Destroy(c.gameObject);
            
            //ups the score
            Score.score += 1000;

            Destroy(this.gameObject);
        }
    }
}
