using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    public Player player;

    public void FlipCoin()
    {
        if (player.coins < 10)
        {
            Debug.Log("Not enough coins");
            return;
        }

        player.coins -= 10;

        int result = Random.Range(0, 2); // 0 or 1

        if (result == 1)
        {
            player.parts += 1;    //  player scriptet ska ha en del för att detta ska funka
            Debug.Log("WIN: +1 part");
        }
        else
        {
            Debug.Log("LOSE");
        }

        Debug.Log("Coins: " + player.coins + " | Parts: " + player.parts);
    }
}
