using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
     //public CharacterController controller;

    public Rigidbody rb;


    public float speed = 12f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
    bool isGrounded;
    public bool playerMovement = true;
    public float mouseSensitivity = 100f;
    Animator myAnim;
    float xRotation = 0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        myAnim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
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


            rb.velocity = (new Vector3(move.x * speed, rb.velocity.y, move.z * speed));

            myAnim.SetBool("OnGround", isGrounded);
            myAnim.SetFloat("speed", rb.velocity.magnitude);

        } else
        {
            rb.velocity = Vector3.zero;

        }
        
    }

    //public void Teleport(Vector3 position, Quaternion rotation)
    //{
    //    transform.position = position;
    //    Physics.SyncTransforms();
    //    look.x = rotation.eulerAngles.y;
    //    look.y = rotation.eulerAngles.z;
    //    velocity = Vector3.zero;
    //}
}
