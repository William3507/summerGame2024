using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{
    public GameObject wallMover;
    public float spawnOffset = 0.75f;
    public float shootInterval = 5f; // Time between spawns in seconds
    private float lastShotTime = 0f;


    void Update()
    {
        if(canSpawn()){
            spawn();
        }
    }

    bool canSpawn(){
        return Time.time - lastShotTime >= shootInterval;
    }

    void spawn(){

        Vector2 spawnPosition = (Vector2)transform.position + Vector2.up * spawnOffset;

        // Instantiate a new basic projectile at the spawnPosition and player's rotation
        GameObject newProjectile = Instantiate(wallMover, spawnPosition, transform.rotation);

        // Get the Rigidbody2D component of the new projectile
        Rigidbody2D rb = newProjectile.GetComponent<Rigidbody2D>();

        lastShotTime = Time.time;

    }
}
