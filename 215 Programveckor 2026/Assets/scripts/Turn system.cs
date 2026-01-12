using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering;
using System;
public class Turnsystem: MonoBehaviour
{
    int player1 = 1;
    int player2 = 2;
    int player3 = 3;
    int player4 = 4;

    public List<int> playerturns = new List<int>();

    private charecterSelect charecterselect;
    private Dicerandom dicerandom;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerturns.Add(player1);
        playerturns.Add(player2);
        playerturns.Add(player3);
        playerturns.Add(player4);
        
    }

    public void nextturn()
    {
        if (charecterselect.current == 1)
        {
            if (Input.GetKey(KeyCode.Space))  
            {
                dicerandom.rolldice();
            }
        }
        if (charecterselect.current == 2)
        {
            if (Input.GetKey(KeyCode.Space)) 
            {
                dicerandom.rolldice();
            }
        }
        if (charecterselect.current == 3)
        {
            if (Input.GetKey(KeyCode.Space)) 
            {
                dicerandom.rolldice(); ;
            }
        }
        if (charecterselect.current == 4)
        {
            if (Input.GetKey(KeyCode.Space))  
            {
                dicerandom.rolldice();
            }
        }
    }
}
