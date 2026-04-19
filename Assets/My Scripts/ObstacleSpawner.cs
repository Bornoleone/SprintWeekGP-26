using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Xml.Linq;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Vector3[] spawnPositions1;//Spawn positions, add Vector3s from inspector to Array
    [SerializeField] private Vector3[] spawnPositions2;
    [SerializeField] private Vector3[] spawnPositions3;
    [SerializeField] private string obstaclePrefabName = "Basic";//Prefab's name from Assets/Resource/Obstacles
    private bool OnBuild;
    public static ObstacleSpawner instance;
    private void Awake()
    {
        instance = this;
    }
    
    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space))//for testing input key
        {
            SpawnObstacles();
        }*/
    }
    public void SpawnObstacles()//called from platform spawning Unity Event
    {
        
        
            Vector3[] VectorArray = GetRandomObstacleArray();
            Debug.Log("array length" + VectorArray.Length);
            for (int i = 0; i < VectorArray.Length; i++)
            {
                Obstacle obstacle = new Obstacle(obstaclePrefabName, VectorArray[i]);

            }
            VectorArray = null; 
            
        
    }
    
    public void DestroyAllObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obstacle in obstacles)
        {
                Destroy(obstacle);
        }
        GameObject[] platforms = GameObject.FindGameObjectsWithTag("Platform");
        foreach (GameObject platform in platforms)
        {
            Destroy(platform);
        }

    }
    private Vector3[] GetRandomObstacleArray()
    {
        
        int rand = Random.Range(1, 4);
        switch(rand)
        {
            case 1: Debug.Log("Random array is spawnPositions1"); return spawnPositions1; 
            case 2: Debug.Log("Random array is spawnPositions2"); return spawnPositions2; 
            case 3: Debug.Log("Random array is spawnPositions3"); return spawnPositions3; 
            default:  Debug.Log("Default case"); break;
        }
        return GetRandomObstacleArray();
    }
    
}
