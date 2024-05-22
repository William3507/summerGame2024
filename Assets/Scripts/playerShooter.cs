using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour
{
    public GameObject basicProjectilePrefab;
    public float shootForce = 10f;

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
        // Instantiate a new basic projectile at the player's position and rotation
        GameObject newProjectile = Instantiate(basicProjectilePrefab, transform.position, transform.rotation);

    }
}
