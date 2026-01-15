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

            if (current == 1)
            {
                PlayerPrefs.SetInt("player1", character);
                PlayerPrefs.Save();
            }
            if (current == 2)
            {
                PlayerPrefs.SetInt("player2", character);
                PlayerPrefs.Save();
            }
            if (current == 3)
            {
                PlayerPrefs.SetInt("player3", character);
                PlayerPrefs.Save();
            }
            if (current == 4)
            {
                PlayerPrefs.SetInt("player4", character);
                PlayerPrefs.Save();
            }
            current++;
            Debug.Log(current);
            if (current > players)
            {
                Debug.Log("all have picked");
                SceneManager.LoadScene("Game");
            }
        }
    }
}