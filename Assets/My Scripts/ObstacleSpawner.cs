using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Vector3 spawnLocation;
    [SerializeField] private Transform playerTransform;
    void Start()
    {
        Obstacle obstacle = new Obstacle("Basic", spawnLocation);
    }
    void Update()
    {
        
    }
    public void SpawnObstacles()
    {

    }
}
