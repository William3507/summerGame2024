using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockMover : MonoBehaviour
{
    public float speed = 3f; // Speed of the projectile
    public float projectileLife = 10f;
    

    void Start()
    {
        // Set the projectile to destroy itself after 2 seconds
        Destroy(gameObject, projectileLife);
    }

    void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
