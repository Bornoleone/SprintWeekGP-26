using UnityEngine;
using UnityEngine.Events;

public class ObstacleSpawningTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ObstacleSpawner.instance.SpawnObstacles();
        }
    }
}
