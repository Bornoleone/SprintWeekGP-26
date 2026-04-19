using UnityEngine;

namespace AH3520
{
    public class Moving : MonoBehaviour
    {
        void Update()
        {
            transform.position += new Vector3(4, 0, 0) * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Destroy"))
            {
                Destroy(gameObject);
            }
        }
    }
}
