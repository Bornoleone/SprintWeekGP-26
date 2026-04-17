using UnityEngine;

namespace AH3520
{
    public class TriggerWithTag : MonoBehaviour
    {
        public GameObject road;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Trigger"))
            {
                Instantiate(road, new Vector3(-7, 0, 0), Quaternion.identity); 
            }
        }
    }
}
