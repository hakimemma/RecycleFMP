using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform target; // Player's transform
    public float moveSpeed = 3f; // Movement speed of the enemy
    public float attackRange = 1.5f; // Distance at which the enemy can attack
    public float attackRate = 1f; // Rate of attack (attacks per second)
    private float nextAttackTime = 0f; // Time until the enemy can attack again

    private void Update()
    {
        if (target == null)
        {
            // If there is no target, do nothing
            return;
        }

        // Move towards the player
        Vector3 direction = target.position - transform.position;
        direction.y = 0f; // Keep the enemy grounded
        direction.Normalize(); // Normalize the direction vector to avoid faster movement diagonally
        transform.Translate(direction * moveSpeed * Time.deltaTime);

        // Check if the enemy is in attack range
        if (Vector3.Distance(transform.position, target.position) <= attackRange)
        {
            // Check if it's time to attack
            if (Time.time >= nextAttackTime)
            {
                // Attack the player
                Attack();
                // Set the next attack time
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        // Placeholder attack behavior
        Debug.Log("Enemy attacks!");
    }
}

