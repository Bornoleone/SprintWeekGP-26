using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleParenting : MonoBehaviour
{

    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Platform"))
        {
            transform.parent.SetParent(collision.transform, true);
            Debug.Log("This Obstacle is Child of The Platform Now!");
        }
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player hit Obstacle");
            ScoreManager.instance.OnDeath();

        }
    }
    
}
