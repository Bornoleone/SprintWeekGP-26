using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Vector3 spawnLocation;
    void Start()
    {
        Obstacle obstacle = new Obstacle("Basic", spawnLocation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
