using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemy;

    [SerializeField]
    private GameObject PosXEdge;
    [SerializeField]
    private GameObject NegXEdge;
    [SerializeField]
    private GameObject PosZEdge;
    [SerializeField]
    private GameObject NegZEdge;

    [SerializeField]
    private float SpawnInterval = 2f;
    private float timer = 0;

    [SerializeField]
    private int MaxEnemies = 20;

    private float xMax;
    private float xMin;
    private float zMax;
    private float zMin;

    void Start()
    {
        xMax = PosXEdge.transform.position.x;
        xMin = NegXEdge.transform.position.x;
        zMax = PosZEdge.transform.position.z;
        zMin = NegZEdge.transform.position.z;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnInterval && GameObject.FindGameObjectsWithTag("Enemy").Length <= MaxEnemies)
        {
            Instantiate(Enemy, new Vector3(Random.Range(xMin, xMax), transform.position.y, Random.Range(zMin, zMax)), transform.rotation);
            timer = 0;
        }
    }
}
