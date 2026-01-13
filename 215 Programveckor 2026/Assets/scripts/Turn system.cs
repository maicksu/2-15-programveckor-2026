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

    Vector2Int playerposition = new Vector2Int(0, 0);

    public List<Vector2Int> playerpositions = new List<Vector2Int>();



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

        playerpositions.Add(new Vector2Int(0, 0)); //[0] också vidare
        playerpositions.Add(new Vector2Int(1, 0)); //[1]
        playerpositions.Add(new Vector2Int(2, 0));
        playerpositions.Add(new Vector2Int(3, 0));
        playerpositions.Add(new Vector2Int(4, 0));
        playerpositions.Add(new Vector2Int(5, 0));
        playerpositions.Add(new Vector2Int(6, 0));
        playerpositions.Add(new Vector2Int(7, 0));
        playerpositions.Add(new Vector2Int(8, 0));
        playerpositions.Add(new Vector2Int(9, 0));
        playerpositions.Add(new Vector2Int(10, 0));
        playerpositions.Add(new Vector2Int(11, 0));
        playerpositions.Add(new Vector2Int(12, 0));
        playerpositions.Add(new Vector2Int(13, 0));
        playerpositions.Add(new Vector2Int(14, 0)); //[14]

        playerpositions.Add(new Vector2Int(14, -1));
        playerpositions.Add(new Vector2Int(14, -2));
        playerpositions.Add(new Vector2Int(14, -3));
        playerpositions.Add(new Vector2Int(14, -4));
        playerpositions.Add(new Vector2Int(14, -5));
        playerpositions.Add(new Vector2Int(14, -6));
        playerpositions.Add(new Vector2Int(14, -7));
        playerpositions.Add(new Vector2Int(14, -8));
        playerpositions.Add(new Vector2Int(14, -9));
        playerpositions.Add(new Vector2Int(14, -10));
        playerpositions.Add(new Vector2Int(14, -11));
        playerpositions.Add(new Vector2Int(14, -12));
        playerpositions.Add(new Vector2Int(14, -13));
        playerpositions.Add(new Vector2Int(14, -14)); //[28]

        playerpositions.Add(new Vector2Int(13, -14));
        playerpositions.Add(new Vector2Int(12, -14));
        playerpositions.Add(new Vector2Int(11, -14));
        playerpositions.Add(new Vector2Int(10, -14));
        playerpositions.Add(new Vector2Int(9, -14));
        playerpositions.Add(new Vector2Int(8, -14));
        playerpositions.Add(new Vector2Int(7, -14));
        playerpositions.Add(new Vector2Int(6, -14));
        playerpositions.Add(new Vector2Int(5, -14));
        playerpositions.Add(new Vector2Int(4, -14));
        playerpositions.Add(new Vector2Int(3, -14));
        playerpositions.Add(new Vector2Int(2, -14));
        playerpositions.Add(new Vector2Int(1, -14));
        playerpositions.Add(new Vector2Int(0, -14)); //[42]

        playerpositions.Add(new Vector2Int(0, -13));
        playerpositions.Add(new Vector2Int(0, -12));
        playerpositions.Add(new Vector2Int(0, -11));
        playerpositions.Add(new Vector2Int(0, -10));
        playerpositions.Add(new Vector2Int(0, -9));
        playerpositions.Add(new Vector2Int(0, -8));
        playerpositions.Add(new Vector2Int(0, -7));
        playerpositions.Add(new Vector2Int(0, -6));
        playerpositions.Add(new Vector2Int(0, -5));
        playerpositions.Add(new Vector2Int(0, -4));
        playerpositions.Add(new Vector2Int(0, -3));
        playerpositions.Add(new Vector2Int(0, -2));
        playerpositions.Add(new Vector2Int(0, -1)); //[55] inte hörn btw det är [0] som är det

    }
    public void PositionsOnPlayers()
    {
        
    }
    public void Turn()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {

            int movement = dicerandom.rolldice();

            Vector2Int CornerNW = playerpositions[0];
            Vector2Int CornerNE = playerpositions[14];
            Vector2Int CornerSE = playerpositions[28];
            Vector2Int CornerSW = playerpositions[42];

            Vector2Int NorthEdge = playerpositions[1-13];
            Vector2Int EastEdge = playerpositions[14-27];
            Vector2Int SouthEdge = playerpositions[29-41];
            Vector2Int WestEdge = playerpositions[43-55];


            

            boardSpace.OnLand();
            
        }
    }
}
