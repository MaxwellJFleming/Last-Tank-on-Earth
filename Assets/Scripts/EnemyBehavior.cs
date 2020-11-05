using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    //How far the enemy can see the player from
    [SerializeField]
    private float LookRadius = 50f;

    private Transform target;
    private NavMeshAgent agent;
    
    void Start()
    {
        target = GameManagerScript.instance.player;
        agent = GetComponent<NavMeshAgent>();
    }

    //moves the enemy towards the player if it's within sight
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= LookRadius)
        {
            agent.SetDestination(target.position);
            //transform.LookAt(target);
        }
    }
}
