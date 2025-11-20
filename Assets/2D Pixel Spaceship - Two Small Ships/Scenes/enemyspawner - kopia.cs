using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public float xRange = 8f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float x = Random.Range(-xRange, xRange);
        Vector3 spawnPos = new Vector3(x, transform.position.y, 0f);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
