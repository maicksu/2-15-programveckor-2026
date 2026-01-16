using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering;
using System;
using UnityEngine.U2D;
public class Turnsystem : MonoBehaviour
{


    public Vector2Int playerposition = new Vector2Int(0, 0);
    public List<Vector2Int> TilePosition = new List<Vector2Int>();
    private int currentPosition = 0;


    private BoardSpace boardSpace;
    private Dicerandom dicerandom;

    private void Awake()
    {
        dicerandom = FindFirstObjectByType<Dicerandom>();
        boardSpace = FindFirstObjectByType<BoardSpace>();

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        TilePosition.Add(new Vector2Int(0, 0)); //[0] också vidare
        TilePosition.Add(new Vector2Int(1, 0)); //[1]
        TilePosition.Add(new Vector2Int(2, 0));
        TilePosition.Add(new Vector2Int(3, 0));
        TilePosition.Add(new Vector2Int(4, 0));
        TilePosition.Add(new Vector2Int(5, 0));
        TilePosition.Add(new Vector2Int(6, 0));
        TilePosition.Add(new Vector2Int(7, 0));
        TilePosition.Add(new Vector2Int(8, 0));
        TilePosition.Add(new Vector2Int(9, 0));
        TilePosition.Add(new Vector2Int(10, 0));
        TilePosition.Add(new Vector2Int(11, 0));
        TilePosition.Add(new Vector2Int(12, 0));
        TilePosition.Add(new Vector2Int(13, 0));
        TilePosition.Add(new Vector2Int(14, 0)); //[14]

        TilePosition.Add(new Vector2Int(14, -1));
        TilePosition.Add(new Vector2Int(14, -2));
        TilePosition.Add(new Vector2Int(14, -3));
        TilePosition.Add(new Vector2Int(14, -4));
        TilePosition.Add(new Vector2Int(14, -5));
        TilePosition.Add(new Vector2Int(14, -6));
        TilePosition.Add(new Vector2Int(14, -7));
        TilePosition.Add(new Vector2Int(14, -8));
        TilePosition.Add(new Vector2Int(14, -9));
        TilePosition.Add(new Vector2Int(14, -10));
        TilePosition.Add(new Vector2Int(14, -11));
        TilePosition.Add(new Vector2Int(14, -12));
        TilePosition.Add(new Vector2Int(14, -13));
        TilePosition.Add(new Vector2Int(14, -14)); //[28]

        TilePosition.Add(new Vector2Int(13, -14));
        TilePosition.Add(new Vector2Int(12, -14));
        TilePosition.Add(new Vector2Int(11, -14));
        TilePosition.Add(new Vector2Int(10, -14));
        TilePosition.Add(new Vector2Int(9, -14));
        TilePosition.Add(new Vector2Int(8, -14));
        TilePosition.Add(new Vector2Int(7, -14));
        TilePosition.Add(new Vector2Int(6, -14));
        TilePosition.Add(new Vector2Int(5, -14));
        TilePosition.Add(new Vector2Int(4, -14));
        TilePosition.Add(new Vector2Int(3, -14));
        TilePosition.Add(new Vector2Int(2, -14));
        TilePosition.Add(new Vector2Int(1, -14));
        TilePosition.Add(new Vector2Int(0, -14)); //[42]

        TilePosition.Add(new Vector2Int(0, -13));
        TilePosition.Add(new Vector2Int(0, -12));
        TilePosition.Add(new Vector2Int(0, -11));
        TilePosition.Add(new Vector2Int(0, -10));
        TilePosition.Add(new Vector2Int(0, -9));
        TilePosition.Add(new Vector2Int(0, -8));
        TilePosition.Add(new Vector2Int(0, -7));
        TilePosition.Add(new Vector2Int(0, -6));
        TilePosition.Add(new Vector2Int(0, -5));
        TilePosition.Add(new Vector2Int(0, -4));
        TilePosition.Add(new Vector2Int(0, -3));
        TilePosition.Add(new Vector2Int(0, -2));
        TilePosition.Add(new Vector2Int(0, -1)); //[55] inte hörn btw det är [0] som är det

        
        transform.position = (Vector2)TilePosition[0];

    }

    public void Turn()
    {
        bool rolling = true;
        bool choising = false;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rolling = false;
            choising = true;
            Debug.Log("Turn");
            int movement = dicerandom.rolldice();
            Debug.Log(movement);

            Vector2Int CornerNW = TilePosition[0];
            Vector2Int CornerNE = TilePosition[14];
            Vector2Int CornerSE = TilePosition[28];
            Vector2Int CornerSW = TilePosition[42];
            transform.position = (Vector2)CornerNW; //remove

            
            if (CornerNW == playerposition)
            {
                if (!Input.GetKeyDown(KeyCode.D) || !Input.GetKeyDown(KeyCode.S))
                {
                    if (choising == true)
                    {
                        Debug.Log("I NW corner");
                        if (Input.GetKeyDown(KeyCode.D))
                        {
                            playerposition.x += movement;
                            transform.position = (Vector2)playerposition;
                            choising = false;
                        }
                        if (Input.GetKeyDown(KeyCode.S))
                        {
                            playerposition.y -= movement;
                            transform.position = (Vector2)playerposition;
                            choising = false;
                        }

                    }
                }
            }
            if (CornerNE == playerposition)
            {
                if (!Input.GetKeyDown(KeyCode.A) || !Input.GetKeyDown(KeyCode.S))
                {
                    if (Input.GetKeyDown(KeyCode.A)) 
                    { 
                        playerposition.x -= movement; 
                        transform.position = (Vector2)playerposition; 
                    }
                    if (Input.GetKeyDown(KeyCode.S)) 
                    {
                        playerposition.y -= movement;
                        transform.position = (Vector2)playerposition;
                    }
                }
            }
            if (CornerSE == playerposition)
            {
                if (!Input.GetKeyDown(KeyCode.A) || !Input.GetKeyDown(KeyCode.W))
                {
                    if (Input.GetKeyDown(KeyCode.A)) { playerposition.x -= movement; transform.position = (Vector2)playerposition; }
                    if (Input.GetKeyDown(KeyCode.W)) { playerposition.y += movement; transform.position = (Vector2)playerposition; }
                    }
            }
            if (CornerSW == playerposition)
            {
                if (!Input.GetKeyDown(KeyCode.D) || !Input.GetKeyDown(KeyCode.W))
                {
                    if (Input.GetKeyDown(KeyCode.D)) { playerposition.x += movement; transform.position = (Vector2)playerposition; }
                    if (Input.GetKeyDown(KeyCode.W)) { playerposition.y += movement; transform.position = (Vector2)playerposition; }
                }
            }

            if(playerposition.y == 0)
            {
                if (!Input.GetKeyDown(KeyCode.D) || !Input.GetKeyDown(KeyCode.A))
                {
                    if (Input.GetKeyDown(KeyCode.D)) { playerposition.x += movement; transform.position = (Vector2)playerposition; }
                    if (Input.GetKeyDown(KeyCode.A)) { playerposition.x -= movement; transform.position = (Vector2)playerposition; }
                }

            }
            if (playerposition.x == 14)
            {
                if (!Input.GetKeyDown(KeyCode.S) ||! Input.GetKeyDown(KeyCode.W))
                {
                    if (Input.GetKeyDown(KeyCode.S)) { playerposition.y -= movement; transform.position = (Vector2)playerposition; }
                    if (Input.GetKeyDown(KeyCode.W)) { playerposition.y += movement; transform.position = (Vector2)playerposition; }
                }
            }
            if (playerposition.y == -14)
            {
                if (!Input.GetKeyDown(KeyCode.D) || !Input.GetKeyDown(KeyCode.A))
                {
                    if (Input.GetKeyDown(KeyCode.D)) { playerposition.x += movement; transform.position = (Vector2)playerposition; }
                    if (Input.GetKeyDown(KeyCode.A)) { playerposition.x -= movement; transform.position = (Vector2)playerposition; }
                }
            }
            if (playerposition.x == 0)
            {
                if (!Input.GetKeyDown(KeyCode.S) || !Input.GetKeyDown(KeyCode.W))
                {
                    if (Input.GetKeyDown(KeyCode.S)) { playerposition.y -= movement; transform.position = (Vector2)playerposition; }
                    if (Input.GetKeyDown(KeyCode.W)) { playerposition.y += movement; transform.position = (Vector2)playerposition; }
                }
            }
            Debug.Log("out of NW corner");
            currentPosition += movement;
            playerposition = TilePosition[currentPosition];
            
            boardSpace.OnLand();
            
        }
    }
}
