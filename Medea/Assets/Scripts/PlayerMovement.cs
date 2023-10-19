using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Adjust this value to control the player's movement speed.
    public GameObject projectilePrefab;
    public float shootForce = 10.0f;
    public float spawnDelay = 0.5f;
    private float lastSpawnTime;

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

        // Shooting logic
        if (Input.GetKey(KeyCode.J) && Time.time - lastSpawnTime >= spawnDelay)
        {
            SpawnProjectile();
        }
    }

    void SpawnProjectile()
    {
        // Calculate the new position for the projectile slightly above the player.
        Vector3 playerPosition = transform.position;
        float yOffset = 1.0f; // Adjust this value to set the height above the player.
        Vector3 spawnPosition = playerPosition + new Vector3(0, yOffset, 0);

        // Create a new projectile from the prefab at the adjusted position.
        GameObject newProjectile = Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

        // Apply a force to the projectile to make it move upwards.
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * shootForce, ForceMode2D.Impulse);

        // Update the last spawn time.
        lastSpawnTime = Time.time;
    }
}
