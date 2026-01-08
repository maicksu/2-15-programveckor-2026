using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering;
using System;
public class NewMonoBehaviourScript : MonoBehaviour
{
    bool player1 = false;
    bool player2 = false;
    bool player3 = false;
    bool player4 = false;

    bool gameon = true; 

    List<bool> playerturns = new List<bool>(); 


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
        playerturns[0] = true;
        bool item = playerturns[0];
        playerturns.RemoveAt(0);
        playerturns.Insert(3, item);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
