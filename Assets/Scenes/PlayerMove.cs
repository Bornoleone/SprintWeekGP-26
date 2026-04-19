using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 6.0F;

    private Vector3 moveDirection = Vector3.zero;

    public Camera camera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;
    float rotationX = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

void Update() {
    CharacterController controller = GetComponent<CharacterController>();

    Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

    move = transform.TransformDirection(move);
    move *= speed;

    controller.Move(move * Time.deltaTime);
    }
    public void Restart() { transform.position = Vector3.zero; }
}