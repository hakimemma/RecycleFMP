using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed = 10f; // Speed of the car
    public float rotationSpeed = 100f; // Rotation speed of the car
    public Transform centerOfMass; // Center of mass for the car (for better physics)

    private Rigidbody rb; // Reference to the car's Rigidbody component

    private void Start()
    {
        // Get the Rigidbody component of the car
        rb = GetComponent<Rigidbody>();

        // Set the center of mass for better physics simulation
        if (centerOfMass != null)
        {
            rb.centerOfMass = centerOfMass.localPosition;
        }
    }

    private void FixedUpdate()
    {
        // Get input from the horizontal axis (A/D keys or Left/Right arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Get input from the vertical axis (W/S keys or Up/Down arrow keys)
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate the movement and rotation based on input
        float moveAmount = verticalInput * moveSpeed * Time.fixedDeltaTime;
        float rotateAmount = horizontalInput * rotationSpeed * Time.fixedDeltaTime;

        // Move the car forward/backward
        rb.MovePosition(transform.position + transform.forward * moveAmount);

        // Rotate the car left/right around its vertical axis
        Quaternion rotation = Quaternion.Euler(0f, rotateAmount, 0f);
        rb.MoveRotation(rb.rotation * rotation);
    }
}

