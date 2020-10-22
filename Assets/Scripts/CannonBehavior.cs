using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBehavior : MonoBehaviour
{
    [SerializeField]
    private float BulletSpeed = 10f;
    
    [SerializeField]
    private GameObject Bullet;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = Instantiate(Bullet, transform.position, transform.rotation);
            b.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * BulletSpeed * Time.deltaTime);
        }
    }
}