using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject playerPrefab;  // Assign the player prefab in the inspector
    private List<GameObject> players = new List<GameObject>();

    void Start()
    {
        GameObject initialPlayer = Instantiate(playerPrefab, transform.position, Quaternion.identity);
        initialPlayer.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);  // Set the scale of the initial player
        players.Add(initialPlayer);
    }

public void AddPlayer(float spacing)
    {
        int maxInRow = 12;

        int currentRow = players.Count / maxInRow;
        int positionInRow = players.Count % maxInRow;

        float xOffset = (positionInRow - maxInRow / 2) * spacing;
        float yOffset = -currentRow * spacing;

        Vector3 newPosition = new Vector3(xOffset, yOffset, 0) + players[0].transform.position;
        GameObject newPlayer = Instantiate(playerPrefab, newPosition, Quaternion.identity);
        newPlayer.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);  // Set the scale to 0.25 of the original
        players.Add(newPlayer);
    }
}


