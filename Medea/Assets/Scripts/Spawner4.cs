using UnityEngine;

public class Spawner4 : MonoBehaviour
{
    public GameObject prefabToSpawn4;
    public BoxCollider2D spawnArea;  // The BoxCollider2D defining the spawning area.
    public float spawnInterval = 0.0f; // The interval between spawns in seconds.

    public ScoreTracker score;
    private float nextSpawnTime;
    private Bounds spawnBounds;

    void Start()
    {
        spawnBounds = spawnArea.bounds;
        nextSpawnTime = Time.time + spawnInterval;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime && score.score >= 35000)
        {
            SpawnPrefab();
            nextSpawnTime = Time.time + spawnInterval;
        }
        SpawnTimer();
    }

    void SpawnPrefab()
    {
        float randomX = Random.Range(spawnBounds.min.x, spawnBounds.max.x);
        float randomY = Random.Range(spawnBounds.min.y, spawnBounds.max.y);

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        Instantiate(prefabToSpawn4, spawnPosition, Quaternion.identity);
    }
    void SpawnTimer()
    {
        if (score.score >= 0 && score.score < 42500)
        {
            spawnInterval = 15.0f;
        }
        else if (score.score >= 42500 && score.score < 50000)
        {
            spawnInterval = 10.0f;
        }
        else if (score.score >= 50000 && score.score < 60000)
        {
            spawnInterval = 7.5f;
        }
        else if (score.score >= 60000 && score.score < 79000)
        {
            spawnInterval = 6.5f;
        }
        else if (score.score >= 79000 && score.score < 86500)
        {
            spawnInterval = 5f;
        }
        else if (score.score >= 86500 && score.score < 125000)
        {
            spawnInterval = 4.5f;
        }
        else if (score.score >= 125000 && score.score < 175000)
        {
            spawnInterval = 4f;
        }
        else if (score.score >= 175000)
        {
            spawnInterval = 3f;
        }
    }
}
