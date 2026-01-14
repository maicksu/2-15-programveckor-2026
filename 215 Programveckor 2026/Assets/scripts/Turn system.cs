using System.Collections.Generic;
using UnityEngine;

public class Turnsystem : MonoBehaviour
{
    public Vector2Int playerposition = new Vector2Int(0, 0);
    public List<Vector2Int> TilePosition = new List<Vector2Int>();
    public int movement = 0;
    public bool isMoving = false;

    public Dicerandom dicerandom;   // assign in Inspector
    public BoardSpace boardSpace;   // assign in Inspector

    private int currentPosition = 0;

    private void Start()
    {
        // North edge
        for (int x = 0; x <= 14; x++) TilePosition.Add(new Vector2Int(x, 0));
        // East edge
        for (int y = -1; y >= -14; y--) TilePosition.Add(new Vector2Int(14, y));
        // South edge
        for (int x = 13; x >= 0; x--) TilePosition.Add(new Vector2Int(x, -14));
        // West edge
        for (int y = -13; y <= -1; y++) TilePosition.Add(new Vector2Int(0, y));

        playerposition = TilePosition[0];
        currentPosition = 0;
    }

    private void Update()
    {
        // Start movement when Space pressed
        if (!isMoving && Input.GetKeyDown(KeyCode.Space))
        {
            movement = dicerandom.rolldice();
            isMoving = true;
            Debug.Log("Dice rolled: " + movement);
        }

        // Move step by step along the board
        if (isMoving && movement > 0)
        {
            currentPosition++;
            if (currentPosition >= TilePosition.Count)
                currentPosition = 0;

            playerposition = TilePosition[currentPosition];
            movement--;

            // Trigger effects for this tile
            boardSpace.OnLand();
        }

        if (movement == 0)
            isMoving = false;

        // Optional: update visual position
        // transform.position = new Vector3(playerposition.x, 0, playerposition.y);
    }
}
