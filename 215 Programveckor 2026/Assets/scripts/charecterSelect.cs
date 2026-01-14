using Assets.scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charecterSelect : MonoBehaviour
{
    public int players = 4;
    public int current = 1;

    private int[] playerselect;

    private Winconditions winconditions;
    private Turnsystem turnsystem;

    private void Start()
    {
        who();
    }

    private void who()
    {
        playerselect = new int[players];
        for (int i = 0; i < players; i++)
        {
            playerselect[i] = -1;
        }
    }

    public void picked(int character)
    {
        if (playerselect == null || playerselect.Length == 0)
        {
            who();
        }

        // prevent picking the same character twice
        for (int i = 0; i < playerselect.Length; i++)
        {
            if (playerselect[i] == character)
            {
                Debug.Log("Character already picked");
                return;
            }
        }

        if (current <= players)
        {
            int playerIndex = current - 1;
            playerselect[playerIndex] = character;

            Debug.Log("Player " + current + " picked character " + character);
            current++;
        }
        else
        {
            Debug.Log("all have picked");
            SceneManager.LoadScene("Game");
        }
    }
}