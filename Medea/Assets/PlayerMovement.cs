using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this value to control the player's movement speed.

    void Update()
    {
        float horizontalInput = 0.0f;
        float verticalInput = 0.0f;

        // Check for A (left) and D (right) keys.
        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1.0f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1.0f;
        }

        // Check for W (up) and S (down) keys.
        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 1.0f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1.0f;
        }

        // Calculate the new position of the player.
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0);
        Vector3 newPosition = transform.position + movement * moveSpeed * Time.deltaTime;

        // Move the player to the new position.
        transform.position = newPosition;
    }
}