using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject basicProjectilePrefab;
    public float shootForce = 10f;
    public float spawnOffset = 0.5f;
    public float shootInterval = 0.5f; // Time between shots in seconds
    private float lastShotTime = 0f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && CanShoot()) // Change "Fire1" to your desired input
        {
            Shoot();
        }
    }

    bool CanShoot()
    {
        // Check if enough time has passed since the last shot
        return Time.time - lastShotTime >= shootInterval;
    }

    void Shoot()
    {
        Vector2 spawnPosition = (Vector2)transform.position + Vector2.up * spawnOffset;

        // Instantiate a new basic projectile at the spawnPosition and player's rotation
        GameObject newProjectile = Instantiate(basicProjectilePrefab, spawnPosition, transform.rotation);

        // Get the Rigidbody2D component of the new projectile
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();

        if (rb != null)
        {
            // Apply force to the projectile in the forward direction of the player
            rb.AddForce(transform.up * shootForce, ForceMode2D.Impulse);
        }
        else
        {
            Debug.LogError("The basicProjectile prefab does not have a Rigidbody2D component.");
        }

        // Update last shot time
        lastShotTime = Time.time;
    }
}

