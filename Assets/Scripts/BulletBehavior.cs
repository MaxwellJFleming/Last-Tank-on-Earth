using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private ScoreCounter score;

    private void Start()
    {
        score = ScoreCounter.instance;
    }

    private void OnTriggerEnter(Collider c)
    {
        //if it his an enemy, the enemy is destroyed and the score is increased.
        if (c.gameObject.CompareTag("Enemy"))
        {
            Destroy(c.gameObject);
            score.IncrementScore(1000);
        }
        Destroy(this.gameObject); //destroys the bullet (no matter what collision it enters)
    }
}
