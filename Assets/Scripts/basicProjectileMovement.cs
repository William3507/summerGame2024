using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicProjectileMovement : MonoBehaviour
{
    public float speed = 8f; // Speed of the projectile
    public float projectileLife = 4f;

    void Start()
    {
        // Set the projectile to destroy itself after 2 seconds
        Destroy(gameObject, projectileLife);
    }

    void Update()
    {
        // Move the projectile forward
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

        void OnCollisionEnter2D(Collision2D other)
    {
        Debug.LogError("Collided");

        if (other.gameObject.CompareTag("basicEnemy")) 
        {
            Debug.LogError("Collided");

            Destroy(gameObject);
        }
    }
}
