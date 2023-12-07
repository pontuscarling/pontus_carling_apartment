using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{


    public Transform cameraTransform;
    public float movementSpeed = 5f;
    public Rigidbody rb;

    float horizontal;
    float vertical;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }
    private void FixedUpdate()
    {
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;


        forward.y = 0;
        right.y = 0;


        Vector3 direction = forward * vertical + right * horizontal;

        Vector3 movement = transform.position + direction.normalized * Time.fixedDeltaTime * movementSpeed;

        rb.MovePosition(movement);

        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direction), 10f * Time.fixedDeltaTime);
        }
    }
}
