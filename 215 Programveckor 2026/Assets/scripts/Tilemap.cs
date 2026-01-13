using System.Collections.Generic;
using UnityEngine;

public class Tilemap : MonoBehaviour
{

    List<Vector2Int> tiles = new List<Vector2Int>();

   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int y = 1; y <= 15; y++)
        {
            tiles.Add(new Vector2Int(0, y));
        }
        for (int y = 1; y <= 15; y++)
        {
            tiles.Add(new Vector2Int(15, y));
        }
        for (int x = 1; x <= 15; x++)
        {
            tiles.Add(new Vector2Int(x,0));
        }
        for (int x = 1; x <= 15; x++)
        {
            tiles.Add(new Vector2Int(x, 15));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
