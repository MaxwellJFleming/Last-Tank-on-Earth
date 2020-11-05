using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Enemy;

    [SerializeField]
    private float SpawnInterval = 2f;
    private float timer = 0;

    [SerializeField]
    private int MaxEnemies = 20;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnInterval && GameObject.FindGameObjectsWithTag("Enemy").Length <= MaxEnemies)
        {
            Instantiate(Enemy, new Vector3(Random.Range(GameManagerScript.instance.xMin, GameManagerScript.instance.xMax), transform.position.y, Random.Range(GameManagerScript.instance.zMin, GameManagerScript.instance.zMax)), transform.rotation);
            timer = 0;
        }
    }
}
