using UnityEngine;

public class fallDown : MonoBehaviour
{
    private static float fallSpeed = 2.0f; // The speed at which the object falls.
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

    public static void setSpeed(float speed)
    {
        fallSpeed = speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger && other.CompareTag("deleter"))
        {
            Debug.Log("Trigger entered!");
            Destroy(gameObject);
        }
    }
}
