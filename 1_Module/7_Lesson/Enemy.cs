using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
    {
        // Move the enemy towards the target
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Rotate to face the target
        transform.LookAt(target.position);
    }

    // Handle collision with the player
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has a Health component
        Health playerHealth = other.GetComponent<Health>();

        if (playerHealth != null)
        {
            // Inflict damage on the player
            playerHealth.TakeDamage(playerDamage);
        }
    }
}