using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{
    //How far the enemy can see the player from
    [SerializeField]
    private float LookRadius = 10f;

    private Transform target;
    private NavMeshAgent agent;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameManagerScript.instance.player;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) <= LookRadius)
            agent.SetDestination(target.position);
    }
}
