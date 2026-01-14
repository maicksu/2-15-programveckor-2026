using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartTurn : MonoBehaviour
{
    private charecterSelect charecterselect;
    private Turnsystem turnsystem;
    private Audiomanager audioManager;
    private BoardSpace boardSpace;
    private int playerturn;
    private charecterSelect CharecterSelect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public List<int> Players = new List<int>();



    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audiomanager>();
    }
    void Start()
    {
        Players.Add(1);
        Players.Add(2);
        Players.Add(3);
        Players.Add(4);


        if (Players[playerturn] == 1)
        {
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Alien);
            }

        }
        if (Players[playerturn] == 2)
        {
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Astronout);
            }
        }
        if (Players[playerturn] == 3)
        {
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Cat);
            }
        }
        if (Players[playerturn] == 4)
        {
            while (!Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Pirate);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (boardSpace.turnover == true) 
        {
            Players[playerturn] += 1;
            if (Players[playerturn] == 5)
            {
                Players[playerturn] = 1;
            }
        }
    }
}
