using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject basicProjectilePrefab;
    public float shootForce = 10f;
    public float spawnOffset = 0.5f;

    void Update()
    {
        // Check if the left mouse button is pressed
        if (Input.GetButtonDown("Fire1")) // Change "Fire1" to your desired input
        {
            Shoot();
        }
    }
void Shoot()
    {
        Vector2 spawnPosition = (Vector2)transform.position + Vector2.up * spawnOffset;

        // Instantiate a new basic projectile at the spawnPosition and player's rotation
        GameObject newProjectile = Instantiate(basicProjectilePrefab, spawnPosition, transform.rotation);

    }
}
