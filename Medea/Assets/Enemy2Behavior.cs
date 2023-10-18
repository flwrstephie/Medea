using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Behavior : MonoBehaviour
{
    private int hp=6;
    public ScoreTracker score;
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
            if(hp > 1)
            {
                hp--;
            }
            else
            {
                score.IncrementScore(650);
                Destroy(gameObject);
            }
        }
    }
}
