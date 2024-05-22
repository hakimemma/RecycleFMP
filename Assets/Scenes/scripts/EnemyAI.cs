using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float detectionRange = 10f;
    public Transform player;
    private Animator myAnim;

    Rigidbody rb;
    Vector3 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myAnim = GetComponent<Animator>();

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Check if player is within detection range
        if (Vector3.Distance(transform.position, player.position) < detectionRange)
        {
            // Calculate direction towards player
            moveDirection = (player.position - transform.position).normalized;

            // Move enemy towards player
            rb.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);
            myAnim.SetBool("moving", true);
        }
        else
        {
            Debug.Log("Player not detected.");
            myAnim.SetBool("moving", false);
        }
    }
}
