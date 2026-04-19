using UnityEngine;

namespace AH3520
{
    public class TriggerWithTag : MonoBehaviour
    {
        public GameObject road;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Triggered");
                Instantiate(road, new Vector3(0, 0, 18), Quaternion.identity); 
            }
        }
    }
}
