using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Behavior : MonoBehaviour
{
    public int hp=5;
    public ScoreTracker score;
    public GameObject deathPrefab;
    // Called when a trigger collision occurs
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other object has an "isTrigger" component
        if (other.isTrigger && other.CompareTag("children"))
        {
            // Destroy the enemy
            Destroy(gameObject);
        }

        else if (other.isTrigger && other.CompareTag("projectile"))
        {
            if (hp > 1)
            {
                hp--;
            }
            else
            {
                score.IncrementScore(300);
                Instantiate(deathPrefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
