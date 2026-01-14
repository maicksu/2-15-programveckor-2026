using Assets.scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charecterSelect : MonoBehaviour
{
    public int players = 4;
    public int current = 1;
    private int[] playerselect;

    private void Start()
    {
        InitializePlayers();
    }

    private void InitializePlayers()
    {
        playerselect = new int[players];
        for (int i = 0; i < players; i++)
        {
            playerselect[i] = -1; // -1 means no character selected
        }
    }

    public void Picked(int character)
    {
        if (playerselect == null || playerselect.Length == 0)
        {
            InitializePlayers();
        }

        // Check if already picked
        for (int i = 0; i < playerselect.Length; i++)
        {
            if (playerselect[i] == character)
            {
                Debug.Log("Character " + character + " already picked!");
                return;
            }
        }

        // Assign character
        int playerIndex = current - 1;
        playerselect[playerIndex] = character;
        Debug.Log("Player " + current + " picked character " + character);

        current++;

        // Load scene if all picked
        if (current > players)
        {
            Debug.Log("All players picked. Loading Game scene...");
            SceneManager.LoadScene("Game"); // make sure scene name matches exactly
        }
    }

    // Get the character chosen by a specific player
    public int GetCharacterForPlayer(int playerNumber)
    {
        if (playerselect != null && playerNumber > 0 && playerNumber <= playerselect.Length)
        {
            return playerselect[playerNumber - 1];
        }
        return -1; // no character selected
    }
}