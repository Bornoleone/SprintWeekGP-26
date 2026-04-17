using System;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Vector3[] spawnPositions;//Spawn positions, add Vector3s from inspector to Array
    [SerializeField] private string obstaclePrefabName = "Basic";//Prefab's name from Assets/Resource/Obstacles
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))//for testing input key
        {
            SpawnArrayObsticles();
        }
    }
    public void SpawnArrayObsticles()//called from platform spawning Unity Event
    {
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            Obstacle obstacle = new Obstacle(obstaclePrefabName, spawnPositions[i]);
           
        }
    }
    public void DestroyAllObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obstacle in obstacles)
        {
                Destroy(obstacle);
        }
        
    }
}
