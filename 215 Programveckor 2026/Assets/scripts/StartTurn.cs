using System.Collections.Generic;
using UnityEngine;

public class StartTurn : MonoBehaviour
{
    private charecterSelect charecterselect;
    private Turnsystem turnsystem;
    private Audiomanager audioManager;

    private int playerTurnIndex = 0;
    private List<int> Players = new List<int>();

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<Audiomanager>();
        charecterselect = GameObject.FindObjectOfType<charecterSelect>();
        turnsystem = GameObject.FindObjectOfType<Turnsystem>();
    }

    private void Start()
    {
        // Add players 1..4
        Players.Add(1);
        Players.Add(2);
        Players.Add(3);
        Players.Add(4);

        Debug.Log("Turn system initialized.");
    }

    private void Update()
    {
        // Press Space to start this player's turn
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int currentPlayer = Players[playerTurnIndex];
            int character = charecterselect.GetCharacterForPlayer(currentPlayer);

            // Play character-specific audio
            switch (character)
            {
                case 1: audioManager.PlaySFX(audioManager.Alien); break;
                case 2: audioManager.PlaySFX(audioManager.Astronout); break;
                case 3: audioManager.PlaySFX(audioManager.Cat); break;
                case 4: audioManager.PlaySFX(audioManager.Pirate); break;
                default: Debug.Log("No character selected for player " + currentPlayer); break;
            }

            // Turnsystem now automatically handles movement in its Update
            // No need to call turnsystem.Turn() anymore

            // Move to next player's turn
            playerTurnIndex++;
            if (playerTurnIndex >= Players.Count)
                playerTurnIndex = 0; // loop back to first player

            Debug.Log("Next player: " + Players[playerTurnIndex]);
        }
    }
}