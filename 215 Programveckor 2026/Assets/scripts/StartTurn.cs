using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartTurn : MonoBehaviour
{

    private Turnsystem turnsystem;
    private Audiomanager audioManager;
    private BoardSpace boardSpace;
    private int playerturn= 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public List<int> Players = new List<int>();


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audiomanager>();
        turnsystem = GetComponent<Turnsystem>();
        boardSpace = FindFirstObjectByType<BoardSpace>();

    }
    void Start()
    {
        int player1= PlayerPrefs.GetInt("player1");
        int player2 = PlayerPrefs.GetInt("player2");
        int player3 = PlayerPrefs.GetInt("player3");
        int player4 = PlayerPrefs.GetInt("player4");

        Players.Add(player1);
        Players.Add(player2);
        Players.Add(player3);
        Players.Add(player4);


    }

    // Update is called once per frame
    void Update()
    {

        if (Players[playerturn] == 1)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Alien);
            }

        }
        if (Players[playerturn] == 2)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Astronout);
            }
        }
        if (Players[playerturn] == 3)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Cat);
            }
        }
        if (Players[playerturn] == 4)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                turnsystem.Turn();
                audioManager.PlaySFX(audioManager.Pirate);
            }
        }
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
