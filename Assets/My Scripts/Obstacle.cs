using UnityEngine;

public class Obstacle
{
    private GameObject obstaclePrefab;
    private GameObject[] obstaclePrefabs;
    private Transform obstacleTransform;
    private Vector3 obstaclePosition;
    private Quaternion obstacleRotation;
    private string obstacleName;
    
    public Obstacle(string name, Vector3 spawnLocation)
    {
        LoadAssets();
        obstaclePrefab = GetPrefabFromName(name);
        SpawnObstacle(spawnLocation);
    }
    private void LoadAssets()
    {
        obstaclePrefabs = Resources.LoadAll<GameObject>("Obstacles");
        if (obstaclePrefabs.Length == 0) { Debug.Log("Resources folder missing prefabs"); }
        if (obstaclePrefabs.Length > 0) { Debug.Log("Resources Load Successfully"); }
    }
    protected GameObject GetPrefabFromName(string name)
    {
        foreach (GameObject prefab in obstaclePrefabs)
        {
            Debug.Log(prefab.name);
            if (prefab.name == name) return prefab;
        }
        return null;
    }
    public void SpawnObstacle(Vector3 spawnLocation)
    {
        obstaclePosition = spawnLocation;
        obstacleRotation = Quaternion.identity;
        Object.Instantiate(obstaclePrefab, obstaclePosition, obstacleRotation);
    }
}
