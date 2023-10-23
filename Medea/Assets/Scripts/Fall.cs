using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    private float fallSpeed = 2.0f; // The speed at which the object falls.
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();

        // Ensure the Rigidbody2D does not rotate around the Z-axis
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
    void FixedUpdate()
    {
        // Move the GameObject to the right using its Rigidbody2D
        Vector2 movement = new Vector2(0, -fallSpeed);
        rb.velocity = movement;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger && other.CompareTag("children"))
        {
            Debug.Log("Trigger entered!");
            Destroy(gameObject);
        }
    }
}
