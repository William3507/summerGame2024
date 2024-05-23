using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallEnemy : MonoBehaviour
{
    public int health = 1; // Health of the enemy

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("basicProjectile"))
        {

            // Reduce health
            health--;

            // Check if health is depleted
            if (health <= 0)
            {
                Die();
            }
        }
    }

    void Die()
    {
        Destroy(gameObject); // Destroy the enemy GameObject
    }
}
