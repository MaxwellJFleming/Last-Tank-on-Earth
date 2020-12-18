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
        //adds deltaTime time to timer
        timer += Time.deltaTime;

        //spawns a new enemy in a random location if it's been {SpawnInterval} seconds since the last one spawned and there are less than {MaxEnemies} enemies onscreen
        if (timer >= SpawnInterval && GameObject.FindGameObjectsWithTag("Enemy").Length < MaxEnemies)
        {
            GameObject newEnemy = Instantiate(Enemy, new Vector3(Random.Range(GameManagerScript.instance.xMin, GameManagerScript.instance.xMax), transform.position.y, Random.Range(GameManagerScript.instance.zMin, GameManagerScript.instance.zMax)), transform.rotation);

            //rotates the newEnemy a random amount about the y axis
            newEnemy.transform.Rotate(0, Random.Range(0, 360), 0);

            //resets timer
            timer = 0;
        }
    }
}
