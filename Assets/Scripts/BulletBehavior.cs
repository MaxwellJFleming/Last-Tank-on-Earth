using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    //hwo long the bullet stays alive for
    [SerializeField]
    private float Lifetime = 2f;
    
    private void Awake()
    {
        //destroys the bullet after {Lifetime} seconds
        Destroy(this.gameObject, Lifetime);
    }
    private void OnTriggerEnter(Collider c)
    {
        //destroys the bullet when it hits any collider
        Destroy(this.gameObject);
    }
}
