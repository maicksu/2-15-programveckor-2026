using UnityEngine;

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
        if(playerselect == null || playerselect.Length == 0)
        {
            who();
        }

        if(current <= players)
        {
            int playerIndex = current - 1;

            playerselect[playerIndex] = character;
            Debug.Log("Player " + current + " picked character " + character);
            current++;
        }
        else
        {
            Debug.Log("all have picked");
        }
    }
}
