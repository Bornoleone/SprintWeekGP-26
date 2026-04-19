using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Vector3[] spawnPositions;//Spawn positions, add Vector3s from inspector to Array
    [SerializeField] private Vector3[] spawnPositions2;
    [SerializeField] private Vector3[] spawnPositions3;
    [SerializeField] private string obstaclePrefabName = "Basic";//Prefab's name from Assets/Resource/Obstacles
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
        for (int i = 0; i < VectorArray.Length; i++)
        {
            Obstacle obstacle = new Obstacle(obstaclePrefabName, VectorArray[i]);
           
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
    private Vector3[] GetRandomObstacleArray()
    {
        Vector3[] randomArray;
        int rand = Random.Range(1, 4);
        switch(rand)
        {
            case 1: randomArray = spawnPositions;Debug.Log("Random array is spawnPositions"); break;
            case 2: randomArray = spawnPositions2; Debug.Log("Random array is spawnPositions2"); break;
            case 3: randomArray = spawnPositions3; Debug.Log("Random array is spawnPositions3"); break;
            default: randomArray = spawnPositions; Debug.Log("Random array is spawnPositions"); break;
        }
        return randomArray;
    }
}
