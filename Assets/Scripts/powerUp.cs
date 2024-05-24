using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    public float shootIntervalIncrease = 2f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Find the PlayerShooter script attached to the player GameObject
            PlayerShooter playerShooter = other.GetComponent<PlayerShooter>();

            if (playerShooter != null)
            {
                // Increase the shootInterval of the player
                playerShooter.shootInterval /= shootIntervalIncrease;

                // Destroy the power-up GameObject after it has been collected
                Destroy(gameObject);
            }
        }
    }
}