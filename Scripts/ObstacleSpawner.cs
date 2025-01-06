using UnityEngine;

internal class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private float spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnInterval);
    }

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity);
    }
}
