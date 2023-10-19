using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public GameObject prefabToSpawn; // The prefab you want to spawn.
    public GameObject prefabToSpawn2;
    public BoxCollider2D spawnArea;  // The BoxCollider2D defining the spawning area.
    public float spawnInterval = 1.0f; // The interval between spawns in seconds.
    public float spawn2Threshold = 0.25f;
    public Enemy1Behavior enemy1;
    public Enemy2Behavior enemy2;

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
        if (Time.time >= nextSpawnTime)
        {
            // Decide whether to call SpawnPrefab or SpawnPrefab2 randomly.
            if (score.score >= 18000 && Random.value < spawn2Threshold)
            {
                SpawnPrefab2();
            }
            else
            {
                SpawnPrefab();
            }
            nextSpawnTime = Time.time + spawnInterval;
        }
        SpawnTimer();
        SpawnThreshold();
    }

    void SpawnPrefab()
    {
        float randomX = Random.Range(spawnBounds.min.x, spawnBounds.max.x);
        float randomY = Random.Range(spawnBounds.min.y, spawnBounds.max.y);

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
    }

    void SpawnPrefab2()
    {
        float randomX = Random.Range(spawnBounds.min.x, spawnBounds.max.x);
        float randomY = Random.Range(spawnBounds.min.y, spawnBounds.max.y);

        Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

        Instantiate(prefabToSpawn2, spawnPosition, Quaternion.identity);
    }


    void SpawnTimer()
    {
        if (score.score >= 3000 && score.score < 6500)
        {
            spawnInterval = 5.0f;
        }
        else if (score.score >= 6500 && score.score < 10000)
        {
            spawnInterval = 3.5f;
        }
        else if (score.score >= 10000 && score.score < 15000)
        {
            spawnInterval = 1.5f;
        }
        else if (score.score >= 15000 && score.score < 25000)
        {
            spawnInterval = 1.0f;
        }
        else if (score.score >= 25000 && score.score < 40000)
        {
            spawnInterval = 0.75f;
            enemy1.hp = 7;
            enemy2.hp = 3;
        }
        else if (score.score >= 40000 && score.score < 52500)
        {
            spawnInterval = 0.66f;
            enemy1.hp = 9;
        }
        else if (score.score >= 52500 && score.score < 60000)
        {
            spawnInterval = 0.50f;
            enemy1.hp = 12;
            enemy2.hp = 5;
        }
        else if (score.score >= 60000 && score.score < 80000)
        {
            spawnInterval = 0.40f;
            enemy1.hp = 15;
            enemy2.hp = 6;
        }
        else if (score.score >= 80000 && score.score < 100000)
        {
            spawnInterval = 0.33f;
            enemy1.hp = 18;
            enemy2.hp = 7;
        }
        else if (score.score >= 100000)
        {
            spawnInterval = 0.25f;
            enemy1.hp = 28;
            enemy2.hp = 10;
        }
    }

    void SpawnThreshold()
    {
        if(score.score >= 23500 && score.score < 27000)
        {
            spawn2Threshold = 0.20f;
        }
        else if(score.score >= 27000 && score.score < 31000)
        {
            spawn2Threshold = 0.27f;
        }
        else if (score.score >= 31000 && score.score < 35000)
        {
            spawn2Threshold = 0.34f;
        }
        else if (score.score >= 35000 && score.score < 45000)
        {
            spawn2Threshold = 0.40f;
        }
        else if (score.score >= 45000 && score.score < 55000)
        {
            spawn2Threshold = 0.45f;
        }
        else if (score.score >= 55000)
        {
            spawn2Threshold = 0.50f;
        }
        else if (score.score >= 80000)
        {
            spawn2Threshold = 0.54f;
        }
    }
}
