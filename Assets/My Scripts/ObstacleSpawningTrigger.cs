
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleSpawningTrigger : MonoBehaviour
{
    private bool switchBool = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && switchBool)
        {
            switchBool = false;
            ObstacleSpawner.instance.SpawnObstacles();
            
        }
    }
    private IEnumerator Stall()
    {

        yield return new WaitForSeconds(8);
    }
}
