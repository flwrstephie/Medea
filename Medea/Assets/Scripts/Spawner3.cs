using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public GameObject[] prefabsToSpawn3; // An array of objects to randomly spawn.
    public BoxCollider2D spawnArea;  // The BoxCollider2D defining the spawning area.
    public float minSpawnInterval = 2.0f; // The minimum interval between spawns in seconds.
    public float maxSpawnInterval = 5.0f; // The maximum interval between spawns in seconds.

    private Bounds spawnBounds;
    private float nextSpawnTime;

    void Start()
    {
        spawnBounds = spawnArea.bounds;
        SetRandomSpawnTime();
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnPrefab();
            SetRandomSpawnTime();
        }
    }

    void SpawnPrefab()
    {
        if (prefabsToSpawn3.Length == 0)
        {
            Debug.LogWarning("No prefabs to spawn. Please assign prefabs in the inspector.");
            return;
        }

        Vector3 randomPosition = new Vector3(
            Random.Range(spawnBounds.min.x, spawnBounds.max.x),
            Random.Range(spawnBounds.min.y, spawnBounds.max.y),
            0
        );

        int randomPrefabIndex = Random.Range(0, prefabsToSpawn3.Length);
        Instantiate(prefabsToSpawn3[randomPrefabIndex], randomPosition, Quaternion.identity);
    }

    void SetRandomSpawnTime()
    {
        float randomInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
        nextSpawnTime = Time.time + randomInterval;
    }
}
