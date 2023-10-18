using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject prefabToSpawn3;
    public BoxCollider2D spawnArea;  // The BoxCollider2D defining the spawning area.
    public float spawnInterval = 0.0f; // The interval between spawns in seconds.
    public Enemy3Behavior enemy3;

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

        Instantiate(prefabToSpawn3, spawnPosition, Quaternion.identity);
    }
    void SpawnTimer()
    {
        if (score.score >= 35000 && score.score < 41000)
        {
            spawnInterval = 45.0f;
        }
        else if (score.score >= 41000 && score.score < 48000)
        {
            spawnInterval = 37.5f;
        }
        else if (score.score >= 48000 && score.score < 60000)
        {
            enemy3.hp = 60;
        }
        else if (score.score >= 48000 && score.score < 60000)
        {
            spawnInterval = 33.0f;
        }
        else if (score.score >= 60000)
        {
            spawnInterval = 27.5f;
        }
    }
}
