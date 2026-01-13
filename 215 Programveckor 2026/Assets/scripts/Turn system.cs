using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering;
using System;
public class Turnsystem : MonoBehaviour
{
    int player1 = 1;
    int player2 = 2;
    int player3 = 3;
    int player4 = 4;

    Vector2Int playerposition = new Vector2Int(0, 0);



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
        
    }
    public void PositionsOnPlayers()
    {

    }
    public void Turn()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            
            int movement = dicerandom.rolldice();

            // Corner positions
            bool isCorner =
                (playerposition.x == 0 && playerposition.y == 0) ||
                (playerposition.x == 0 && playerposition.y == 15) ||
                (playerposition.x == 15 && playerposition.y == 0) ||
                (playerposition.x == 15 && playerposition.y == 15);

            // Edge positions (not corners)
            bool isHorizontalEdge =
                playerposition.y == 0 || playerposition.y == 15;

            bool isVerticalEdge =
                playerposition.x == 0 || playerposition.x == 15;

            if (isCorner)
            {
                if (Input.GetKey(KeyCode.D)) playerposition.x += movement;
                if (Input.GetKey(KeyCode.A)) playerposition.x -= movement;
                if (Input.GetKey(KeyCode.W)) playerposition.y += movement;
                if (Input.GetKey(KeyCode.S)) playerposition.y -= movement;
            }
            else if (isHorizontalEdge)
            {
                if (Input.GetKey(KeyCode.D)) playerposition.x += movement;
                if (Input.GetKey(KeyCode.A)) playerposition.x -= movement;
            }
            else if (isVerticalEdge)
            {
                if (Input.GetKey(KeyCode.W)) playerposition.y += movement;
                if (Input.GetKey(KeyCode.S)) playerposition.y -= movement;
            }

            boardSpace.OnLand();
            charecterselect.current++;
        }
    }
}
