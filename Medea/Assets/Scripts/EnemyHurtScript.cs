using UnityEngine;

public class EnemyHurtScript : MonoBehaviour
{
    private Animator animator;
    private bool isHurt = false; // Your custom boolean parameter

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Update the animator parameter based on whether the character is hurt.
        animator.SetBool("IsHurt", isHurt);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the trigger collision is with an object tagged as "projectile."
        if (other.CompareTag("projectile"))
        {
            // The character is hurt.
            isHurt = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Check if the character is no longer colliding with any objects.
        // If so, it's no longer hurt.
        isHurt = false;
    }
}
