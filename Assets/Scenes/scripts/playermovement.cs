using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public float walkSpeed = 12f;
    public float sprintSpeed = 18f; // Speed when sprinting
    public float mouseSensitivity = 100f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    bool isGrounded;
    public bool playerMovement = true;
    Animator myAnim;
    float xRotation = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        myAnim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (playerMovement)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            xRotation += mouseX;
            transform.rotation = Quaternion.Euler(0f, xRotation, 0f);

            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : walkSpeed; // Determine current speed

            rb.velocity = new Vector3(move.x * currentSpeed, rb.velocity.y, move.z * currentSpeed);

            myAnim.SetBool("OnGround", isGrounded);
            myAnim.SetFloat("speed", rb.velocity.magnitude);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }
    }
}

