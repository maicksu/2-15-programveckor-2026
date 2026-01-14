using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering;
using System;
using UnityEngine.U2D;
public class Turnsystem : MonoBehaviour
{
    int player1 = 1;
    int player2 = 2;
    int player3 = 3;
    int player4 = 4;

    public Vector2Int playerposition = new Vector2Int(0, 0);
    public List<Vector2Int> TilePosition = new List<Vector2Int>();
    private int currentPosition = 0;


    public List<int> playerturns = new List<int>();

    private BoardSpace boardSpace;
    private charecterSelect charecterselect;
    private Dicerandom dicerandom;
    private Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerturns.Add(player1);
        playerturns.Add(player2);
        playerturns.Add(player3);
        playerturns.Add(player4);

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

        playerposition = TilePosition[0];
    }
   
    public void Turn()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {

            int movement = dicerandom.rolldice();

            Vector2Int CornerNW = TilePosition[0];
            Vector2Int CornerNE = TilePosition[14];
            Vector2Int CornerSE = TilePosition[28];
            Vector2Int CornerSW = TilePosition[42];

            Vector2Int NorthEdge = TilePosition[1-13];
            Vector2Int EastEdge = TilePosition[14-27];
            Vector2Int SouthEdge = TilePosition[29-41];
            Vector2Int WestEdge = TilePosition[43-55];

            if(CornerNW == playerposition)
            {
                while (!Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.S))
                {
                    if (Input.GetKey(KeyCode.D)) playerposition.x += movement;
                    if (Input.GetKey(KeyCode.S)) playerposition.y -= movement;
                }
            }
            if (CornerNE == playerposition)
            {
                while (!Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.S))
                {
                    if (Input.GetKey(KeyCode.A)) playerposition.x -= movement;
                    if (Input.GetKey(KeyCode.S)) playerposition.y -= movement;
                }
            }
            if (CornerSE == playerposition)
            {
                while (!Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.W))
                {
                    if (Input.GetKey(KeyCode.A)) playerposition.x -= movement;
                    if (Input.GetKey(KeyCode.W)) playerposition.y += movement;
                }
            }
            if (CornerSW == playerposition)
            {
                while (!Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.W))
                {
                    if (Input.GetKey(KeyCode.D)) playerposition.x += movement;
                    if (Input.GetKey(KeyCode.W)) playerposition.y += movement;
                }
            }

            if(NorthEdge == playerposition)
            {
                while (!Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.A))
                {
                    if (Input.GetKey(KeyCode.D)) playerposition.x += movement;
                    if (Input.GetKey(KeyCode.A)) playerposition.x -= movement;
                }

            }
            if (EastEdge == playerposition)
            {
                while (!Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.W))
                {
                    if (Input.GetKey(KeyCode.S)) playerposition.y -= movement;
                    if (Input.GetKey(KeyCode.W)) playerposition.y += movement;
                }
            }
            if (SouthEdge == playerposition)
            {
                while (!Input.GetKey(KeyCode.D) || !Input.GetKey(KeyCode.A))
                {
                    if (Input.GetKey(KeyCode.D)) playerposition.x += movement;
                    if (Input.GetKey(KeyCode.A)) playerposition.x -= movement;
                }
            }
            if (WestEdge == playerposition)
            {
                while (!Input.GetKey(KeyCode.S) || !Input.GetKey(KeyCode.W))
                {
                    if (Input.GetKey(KeyCode.S)) playerposition.y -= movement;
                    if (Input.GetKey(KeyCode.W)) playerposition.y += movement;
                }
            }
            
            currentPosition += movement;
            playerposition = TilePosition[currentPosition];
            
            boardSpace.OnLand();
            
        }
    }
}
