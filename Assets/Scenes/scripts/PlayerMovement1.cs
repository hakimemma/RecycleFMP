using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    public float jumpForce = 5f;
    public LayerMask groundLayer;
    private Rigidbody rb;
    private bool isGrounded;
    public Vector3 feetPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the player is grounded using a SphereCast
        isGrounded = Physics.CheckSphere(transform.position + feetPosition, 0.1f, groundLayer);

        // Handle jump input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    // Visualize ground check in the editor
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position + feetPosition, 0.1f);
    }
}