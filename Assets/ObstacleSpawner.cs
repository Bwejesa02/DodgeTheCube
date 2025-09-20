using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public float xRange = 6f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 5f, 0f);
        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);
    }
}
