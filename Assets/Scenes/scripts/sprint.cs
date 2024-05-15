using UnityEngine;

public class sprint : MonoBehaviour
{
    public float walkSpeed = 5f; // Regular walking speed
    public float sprintSpeed = 10f; // Sprinting speed
    public float sprintCooldown = 2f; // Cooldown duration between sprints
    private float sprintTimer = 0f; // Timer to track sprint cooldown

    private CharacterController characterController;
    private bool isSprinting = false;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Check if sprint key (e.g., Left Shift) is pressed and sprint cooldown is over
        if (Input.GetKey(KeyCode.LeftShift) && Time.time > sprintTimer)
        {
            isSprinting = true;
            sprintTimer = Time.time + sprintCooldown; // Set cooldown timer
        }
        else
        {
            isSprinting = false;
        }

        // Move the player
        float speed = isSprinting ? sprintSpeed : walkSpeed; // Determine speed based on sprint state
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;
        characterController.Move(moveDirection * speed * Time.deltaTime);
    }
}

