using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpDuplicate : MonoBehaviour
{
    public GameObject playerPrefab;  // Assign the player prefab in the inspector
    public float horizontalSpacing = 1.5f;  // Horizontal spacing between duplicates

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerManager playerManager = FindObjectOfType<PlayerManager>();
            if (playerManager != null)
            {
                playerManager.AddPlayer(horizontalSpacing);
            }

            // Optionally destroy the power-up object
            Destroy(gameObject);
        }
    }
}

