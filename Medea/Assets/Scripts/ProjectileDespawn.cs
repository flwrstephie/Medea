using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDespawn : MonoBehaviour
{
    // Called when a trigger collision occurs
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other object has an "isTrigger" component
        if (other.isTrigger && other.CompareTag("despawn"))
        {
            // Destroy the projectile object
            Destroy(gameObject);
        }
    }
}
